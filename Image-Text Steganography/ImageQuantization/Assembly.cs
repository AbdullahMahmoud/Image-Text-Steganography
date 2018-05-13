using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace ImageQuantization
{
    class Assembly
    {
        [DllImport("Project.dll")]
        private static extern void Encryption(string FN,int SFN,string OFN ,int SOFN ,string SM ,int SSM);

        [DllImport("Project.dll")]
        private static extern void Decryption(string FN, int SFN, char[] SM);

        public static void Encrypts(string FN1, int SFN1, string OFN1, int SOFN1, string SM1, int SSM1)
        {
            Encryption(FN1,SFN1,OFN1 ,SOFN1 , SM1 ,SSM1);
        }
        public static char[] Decrypts(string FN1, int SFN1, char[] SM1)
        {
            Decryption( FN1,  SFN1, SM1);
            return SM1;
        }
    }
}
