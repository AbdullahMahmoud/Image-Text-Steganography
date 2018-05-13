INCLUDE Irvine32.inc
INCLUDE macros.inc
BUFFER_SIZE = 1000000
.data
buffer BYTE BUFFER_SIZE DUP(?)
filename BYTE 1000 DUP(0)
Ouputfilename BYTE 1000 DUP(0)
fileHandle HANDLE ?
SecretStr byte 1002 dup(0)
BufferLength dword ?
FileNameLength dword ?
.code

;Write your functions here
;Do not forget to modify main.def file accordingly 

; ********************************************************************************************* Do Encryption *****************************************************************************

Encryption proc FN: PTR byte , SFN: Dword , OFN: PTR byte , SOFN: Dword , SM: PTR byte , SSM: Dword

	mov ecx , SFN
	Mov edi , FN
	mov esi , 0
	lp1:
	mov al , [edi+esi]
	mov filename[esi] , al
	inc esi
	loop lp1

	mov ecx , SOFN
	Mov edi , OFN
	mov esi , 0
	lp2:
	mov al , [edi+esi]
	mov Ouputfilename[esi] , al
	inc esi
	loop lp2


	mov ecx , SSM
	Mov edi , SM
	mov esi , 0
	lp3:
	mov al , [edi+esi]
	mov SecretStr[esi] , al
	inc esi
	loop lp3


	; ********************* Open the file for input.
	mov edx , offset filename 
	call OpenInputFile
	mov fileHandle , eax
	cmp  eax , INVALID_HANDLE_VALUE 
	je quit

	; ********************* Read the file into a buffer.
	mov edx , offset buffer
	mov ecx , buffer_size
	call readfromfile
	mov BufferLength , eax
	mov buffer[eax],0

	call SkipCoordinates


	mov eax , SSM
	mov ecx , SSM
	mov edi , 0

	push ecx
	call StoreMesssageSize
	pop ecx

		MainLoop:
			push ecx

			mov ecx , 8
			mov bl , SecretStr[edi];
			xor bl , 239                          ;Bouns Encrypts it before store it 
				EncryptChar:

                    Call GetLastDigit

					shr bl , 1
					jc one
					and buffer[esi] , 0FEh
					jmp done1
					one:
					or buffer[esi] , 01h
					done1:
					add esi , 3

				loop EncryptChar

			Call SkipLastBlue
			inc edi
			pop ecx
		loop MainLoop


	call SaveOutput
	quit:
	ret
Encryption endp

; ********************************************************************************************* Do Decryption *****************************************************************************

Decryption proc FN: PTR byte , SFN: Dword , SM: PTR byte
	mov edi , SM
	mov byte ptr [edi] , 'M'

	mov ecx , SFN
	Mov edi , FN
	mov esi , 0
	lp1:
	mov al , [edi+esi]
	mov filename[esi] , al
	inc esi
	loop lp1

	; ********************* Open the file for input.
	mov edx , offset filename 
	call OpenInputFile
	mov fileHandle , eax
	cmp  eax , INVALID_HANDLE_VALUE 
	;je quit

	; ********************* Read the file into a buffer.
	mov edx , offset buffer
	mov ecx , buffer_size
	call readfromfile
	mov BufferLength , eax
	mov buffer[eax],0

	call SkipCoordinates

    call GetMesssageSize


	mov ebx , eax
	mov ecx , eax
	mov edi , 0

		MainLoop:
			push ecx
			mov ecx , 8
				DecryptChar:

                    Call GetLastDigit

					shr buffer[esi] , 1
					rcr SecretStr[edi] , 1
					add esi , 3

				loop DecryptChar

			Call SkipLastBlue
			xor SecretStr[edi] , 239                          ;Bouns Decrypts it to get the original char
			inc edi
			pop ecx
		loop MainLoop


	mov ecx , ebx
	Mov edi , SM
	mov esi , 0
	lp2:
	mov al , SecretStr[esi]
	mov [edi+esi] , al
	inc esi
	loop lp2

quit:
	ret
Decryption endp

; ********************************************************************************* Skip First Two Lines ***********************************************************************************************

SkipCoordinates proc
mov esi , 0
	mov edi , 0
	lp:
	cmp buffer[esi] , 0dh
	je Found
	inc esi
	jmp lp
	Found:
	add esi , 2
	inc edi 
	cmp edi , 2
	je done
	jmp lp
	done:
ret
SkipCoordinates endp

; ********************************************************************************** store message size *****************************************************************************

StoreMesssageSize proc
	xor eax , 239
	mov ecx , 4
	lp:
		push ecx
		mov ecx , 8
			inner:
				Call GetLastDigit

					shr eax , 1
					jc one
					and buffer[esi] , 0FEh
					jmp done1
					one:
					or buffer[esi] , 01h
					done1:
					add esi , 3
			loop inner

		Call SkipLastBlue
		pop ecx

	loop lp
	ret
StoreMesssageSize endp

; ********************************************************************************** get message size *****************************************************************************

GetMesssageSize proc
	mov eax , 0
	mov ecx , 4
	lp:
		push ecx
		mov ecx , 8
			inner:
				Call GetLastDigit

					shr buffer[esi] , 1
					rcr eax , 1
					add esi , 3
			loop inner

		Call SkipLastBlue
		pop ecx

	loop lp
	xor eax , 239
	ret
GetMesssageSize endp

; ********************************************************************************** get last digit in the color to store in it *****************************************************************************


GetLastDigit proc
	lp:
		inc esi
		cmp buffer[esi] , 0dh
		je done
	jmp lp
	done:
	dec esi
	ret
GetLastDigit endp

; ********************************************************************************** Save Outut file **********************************************************************************************
SaveOutput proc
    ; ********************* Create a new text file.
	mov edx,OFFSET Ouputfilename
	call CreateOutputFile
	mov fileHandle,eax

	; ********************* Save the new data

	mov eax,fileHandle
	mov edx,OFFSET buffer
	mov ecx , BufferLength 
	call WriteToFile
	call CloseFile
	ret
SaveOutput endp

; ********************************************************************************** Skip Last blue color per char **************************************************************
SkipLastBlue proc
	lp:
			inc esi
			cmp buffer[esi] , 0dh
			je done
	jmp lp

	done:
	add esi , 2
	ret
SkipLastBlue endp



; DllMain is required for any DLL
DllMain PROC hInstance:DWORD, fdwReason:DWORD, lpReserved:DWORD 

mov eax, 1		; Return true to caller. 
ret 				
DllMain ENDP

END DllMain
