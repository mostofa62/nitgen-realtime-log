using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NitgenRealtimeLog
{
    public class Define
    {
        public enum AC_UserAuthType
        {
            AC_USER_AUTHTYPE_FP = 0x01,						// Fingerprint only
            AC_USER_AUTHTYPE_PW = 0x02,						// Password only
            AC_USER_AUTHTYPE_RF = 0x04,						// RF card only
            AC_USER_AUTHTYPE_FACE = 0x10,					// FACE only

            AC_USER_AUTHTYPE_FP_PW_AND = 0x03,				// Both fingerprint AND password
            AC_USER_AUTHTYPE_FP_RF_AND = 0x05,				// Both fingerprint AND RF card
            AC_USER_AUTHTYPE_PW_RF_AND = 0x06,				// Both password AND RF card
            AC_USER_AUTHTYPE_FP_FACE_AND = 0x11,
            AC_USER_AUTHTYPE_PW_FACE_AND = 0x12,
            AC_USER_AUTHTYPE_RF_FACE_AND = 0x14,

            AC_USER_AUTHTYPE_FP_PW_RF_AND = 0x07,			// All fingerprint, password AND RF card
            AC_USER_AUTHTYPE_FP_PW_FACE_AND = 0x13,
            AC_USER_AUTHTYPE_FP_RF_FACE_AND = 0x15,
            AC_USER_AUTHTYPE_PW_RF_FACE_AND = 0x16,

            AC_USER_AUTHTYPE_FP_PW_RF_FACE_AND = 0x17,		//Not Use	

            AC_USER_AUTHTYPE_SOC_FP = 0x41,					// SOC
            AC_USER_AUTHTYPE_SOC_PW = 0X42,					// SOC (not used) SOC단말기에는 0x02가 그대로 들어감
            AC_USER_AUTHTYPE_SOC_RF = 0X44,					// SOC 
            AC_USER_AUTHTYPE_SOC_FP_PW_AND = 0X43,			// SOC
            //AC_USER_AUTHTYPE_SOC_FP_PW_OR = 0x45,			// SOC
            AC_USER_AUTHTYPE_SOC_FP_PW_OR = 0XC3,			// SOC

            AC_USER_AUTHTYPE_FP_PW_OR = 0x83,				// Either fingerprint OR password
            AC_USER_AUTHTYPE_FP_RF_OR = 0x85,				// Either fingerprint OR RF card
            AC_USER_AUTHTYPE_PW_RF_OR = 0x86,				// Either password OR RF card
            AC_USER_AUTHTYPE_FP_FACE_OR = 0x91,
            AC_USER_AUTHTYPE_PW_FACE_OR = 0x92,
            AC_USER_AUTHTYPE_RF_FACE_OR = 0x94,

            AC_USER_AUTHTYPE_FP_PW_RF_OR = 0x87,
            AC_USER_AUTHTYPE_FP_PW_FACE_OR = 0x93,
            AC_USER_AUTHTYPE_FP_RF_FACE_OR = 0x95,
            AC_USER_AUTHTYPE_PW_RF_FACE_OR = 0x96,

            AC_USER_AUTHTYPE_FP_PW_RF_FACE_OR = 0x97,		//Not Use
        };

        // Terminal user privileges for users
        public enum AC_TerminalUserPrivilege
        {
            AC_TERMNIAL_USER_PRIVILEGE_MASTER = 1,			// Terminal Master
            AC_TERMNIAL_USER_PRIVILEGE_USER,				// General user
            AC_TERMNIAL_USER_PRIVILEGE_GUEST = 4,
        };

        // Encryption types for server on communication
        public enum AC_EncType
        {
            AC_COMM_ENCTYPE_NONE = 1,							// No encryption used
            AC_COMM_ENCTYPE_DES									// DES
        };

        //NBioBSP Device ID
        public enum DEVICE_ID
        {
            NONE = (0x0000),
            AUTO = (0x00ff)
        };

        //NBioBSP Device ID
        public enum MinConv
        {
            MINCONV_TYPE_FDU = 1,
        };

        public enum AC_HardwareType
        {
            AC_HARDWARE_TYPE_OLD = 1,						// Old firmware
            AC_HARDWARE_TYPE_2500_MINOR,					// For NAC2500 
            AC_HARDWARE_TYPE_3000_MINOR,					// For NAC3000 
            AC_HARDWARE_TYPE_2500_MINOR_2,					// For NAC2500 (4MF)
            AC_HARDWARE_TYPE_RFCARD_ONLY,					// For only RF Card supported terminal
            AC_HARDWARE_TYPE_5000,							// For NAC_5000
            AC_HARDWARE_TYPE_3000_PLUS,
            AC_HARDWARE_TYPE_2500_PLUS,
            AC_HARDWARE_TYPE_1500,							// For NAC-1500, 9
            AC_HARDWARE_TYPE_2500_SOC,
            AC_HARDWARE_TYPE_1500_RFCARD_ONLY,
            AC_HARDWARE_TYPE_KT101,							// KT Telecop 향 단말기
            AC_HARDWARE_TYPE_5000_FACE_AUTH,				// For NAC_5000
            AC_HARDWARE_TYPE_1500_PLUS_FELICA,				// 일본 Felica향 단말
            AC_HARDWARE_TYPE_1500_PLUS_RFCARD_ONLY_FELICA,	// 일본 Felica향 단말

            AC_HARDWARE_TYPE_SW101_PLUS,					 // SW101 Plus 16
            AC_HARDWARE_TYPE_SW101_PLUS_CARDONLY,
            AC_HARDWARE_TYPE_T5, // SW300
            AC_HARDWARE_TYPE_T3, // SW250
            AC_HARDWARE_TYPE_T1,
            AC_HARDWARE_TYPE_MCP040, // ACU
            AC_HARDWARE_TYPE_T9,
            AC_HARDWARE_TYPE_SW101M2, // 사용자 10,000, RFID 8byte, Log 100,000
            AC_HARDWARE_TYPE_RFONLY_NEW, // 고급형 카드 단말기 2015.11.26

            AC_HARDWARE_TYPE_OLD_APB = 0x101,				// Old firmware
            AC_HARDWARE_TYPE_2500_MINOR_APB,				// For NAC2500 
            AC_HARDWARE_TYPE_3000_MINOR_APB,				// For NAC3000 
            AC_HARDWARE_TYPE_2500_MINOR_2_APB,				// For NAC2500 (4MF)
            AC_HARDWARE_TYPE_RFCARD_ONLY_APB,				// For only RF Card supported terminal	
            AC_HARDWARE_TYPE_5000_APB,						// FOR NAC_5000	
            AC_HARDWARE_TYPE_3000_PLUS_APB,
            AC_HARDWARE_TYPE_2500_PLUS_APB,
            AC_HARDWARE_TYPE_1500_APB,						// For MiniAC
            //AC_HARDWARE_TYPE_2500_SOC
        };

        public enum AC_ServerRFType
        {
            AC_SERVER_RFTYPE_MIFARE,
            AC_SERVER_RFTYPE_MIFARE_34,
            AC_SERVER_RFTYPE_MIFARE_MAX,

            AC_SERVER_RFTYPE_HID = 100,
            AC_SERVER_RFTYPE_HID_26,
            AC_SERVER_RFTYPE_HID_35,
            AC_SERVER_RFTYPE_HID_37,
            AC_SERVER_RFTYPE_HID_MAX,
            AC_SERVER_RFTYPE_HID_32,

            AC_SERVER_RFTYPE_EM = 200,
            AC_SERVER_RFTYPE_EM_26,
            AC_SERVER_RFTYPE_MAX,

            AC_SERVER_RFTYPE_SOC = 300,
            AC_SERVER_RFTYPE_SOC_1K,
            AC_SERVER_RFTYPE_SOC_4K,
            AC_SERVER_RFTYPE_SOC_MAX,

            AC_SERVER_RFTYPE_ICLASS = 400,
            AC_SERVER_RFTYPE_ICLASS_26,
            AC_SERVER_RFTYPE_ICLASS_MIFARE,
            AC_SERVER_RFTYPE_ICLASS_CEPAS,
            AC_SERVER_RFTYPE_ICLASS_MAX,

            AC_SERVER_RFTYPE_ETC = 1000,
            AC_SERVER_RFTYPE_ETC_INDALA,
            AC_SERVER_RFTYPE_ETC_MAX,
        };
    }
}
