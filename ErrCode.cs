using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NitgenRealtimeLog
{
    public class ErrCode
    {
        // Function success
        public const int ACAMAPI_ERROR_NONE = (0x0000);


        // ################################################################################################
        //	   Definition of Category of error
        // ################################################################################################
        public const int ACAMAPI_ERROR_GENERAL = (0x20010000);
        public const int ACAMAPI_ERROR_COMM = (0x20010100);
        public const int ACAMAPI_ERROR_USER = (0x20010200);
        public const int ACAMAPI_ERROR_GROUP = (0x20010300);
        public const int ACAMAPI_ERROR_NODE = (0x20010400);
        public const int ACAMAPI_ERROR_SYSEVENT = (0x20010500);
        public const int ACAMAPI_ERROR_LOGINEVENT = (0x20010600);
        public const int ACAMAPI_ERROR_REALTIME = (0x20010700);
        public const int ACAMAPI_ERROR_FIRMWARE = (0x20010800);
        public const int ACAMAPI_ERROR_SERVER = (0x20010900);
        public const int ACAMAPI_ERROR_DBSVRAGENT = (0x20010A00);
        public const int ACAMAPI_ERROR_PRIVILEGE = (0x20010B00);
        public const int ACAMAPI_ERROR_CUSTOM_MESSAGE = (0x20011000);


        // ################################################################################################
        //	   Definition of errors for general status.
        // ################################################################################################
        public const int ACAMAPI_ERROR_INVALIDHANDLE = (ACAMAPI_ERROR_GENERAL + 0x01);
        public const int ACAMAPI_ERROR_INVALIDPOINTER = (ACAMAPI_ERROR_GENERAL + 0x02);
        public const int ACAMAPI_ERROR_INVALIDPARAMETER = (ACAMAPI_ERROR_GENERAL + 0x03);
        public const int ACAMAPI_ERROR_CREATEOBJECTFAIL = (ACAMAPI_ERROR_GENERAL + 0x04);
        public const int ACAMAPI_ERROR_CHECKLOGINFAIL = (ACAMAPI_ERROR_GENERAL + 0x05);
        public const int ACAMAPI_ERROR_INVALIDIMGTYPE = (ACAMAPI_ERROR_GENERAL + 0x06);
        public const int ACAMAPI_ERROR_INVALIDIMGPATH = (ACAMAPI_ERROR_GENERAL + 0x07);
        public const int ACAMAPI_ERROR_STARTTERMINALSTATUS = (ACAMAPI_ERROR_GENERAL + 0x08);
        public const int ACAMAPI_ERROR_ODBCCONNECTFAIL = (ACAMAPI_ERROR_GENERAL + 0x09);
        public const int ACAMAPI_ERROR_GETSYSTEM = (ACAMAPI_ERROR_GENERAL + 0x0A);
        public const int ACAMAPI_ERROR_SETSYSTEM = (ACAMAPI_ERROR_GENERAL + 0x0B);
        public const int ACAMAPI_ERROR_INVALIDUSERIDLEN = (ACAMAPI_ERROR_GENERAL + 0x0C);
        public const int ACAMAPI_ERROR_INVALIDFINGERCNT = (ACAMAPI_ERROR_GENERAL + 0x0D);
        public const int ACAMAPI_ERROR_INVALID_IDENTIFYTIMEOUT = (ACAMAPI_ERROR_GENERAL + 0x0E);
        public const int ACAMAPI_ERROR_INVALID_CHECKFP = (ACAMAPI_ERROR_GENERAL + 0x0F);
        public const int ACAMAPI_ERROR_SETOPTION_NOTNORMAL_SERVER = (ACAMAPI_ERROR_GENERAL + 0x10);
        public const int ACAMAPI_ERROR_PRIVILEGE_FAIL = (ACAMAPI_ERROR_GENERAL + 0x11);
        public const int ACAMAPI_ERROR_DEVICEOPEN_FAIL = (ACAMAPI_ERROR_GENERAL + 0x12);



        // ################################################################################################
        //	   Definition of errors for communication.
        // ################################################################################################
        public const int ACAMAPI_ERROR_CONNECTIONFAIL = (ACAMAPI_ERROR_COMM + 0x01);
        public const int ACAMAPI_ERROR_DISCONNECTIONFAIL = (ACAMAPI_ERROR_COMM + 0x02);
        public const int ACAMAPI_ERROR_TIMEOUT = (ACAMAPI_ERROR_COMM + 0x03);
        public const int ACAMAPI_ERROR_SENDMSGFAIL = (ACAMAPI_ERROR_COMM + 0x04);
        public const int ACAMAPI_ERROR_SETENCTYPEFAIL = (ACAMAPI_ERROR_COMM + 0x05);
        public const int ACAMAPI_ERROR_SERVERNOTEXIST = (ACAMAPI_ERROR_COMM + 0x06);
        public const int ACAMAPI_ERROR_SERVERNOTNORMAL = (ACAMAPI_ERROR_COMM + 0x07);
        public const int ACAMAPI_ERROR_SAFEARRAY_CREATE = (ACAMAPI_ERROR_COMM + 0x08);
        public const int ACAMAPI_ERROR_INVALID_PARAM_IP = (ACAMAPI_ERROR_COMM + 0x09);



        // ################################################################################################
        //	   Definition of errors for user information.
        // ################################################################################################
        public const int ACAMAPI_ERROR_USERNOTFOUND = (ACAMAPI_ERROR_USER + 0x01);
        public const int ACAMAPI_ERROR_USERLISTNOTOPEN = (ACAMAPI_ERROR_USER + 0x02);
        public const int ACAMAPI_ERROR_INVALIDUSERID = (ACAMAPI_ERROR_USER + 0x03);
        public const int ACAMAPI_ERROR_INVALIDPASSWORD = (ACAMAPI_ERROR_USER + 0x04);
        public const int ACAMAPI_ERROR_INVALIDREGDATE = (ACAMAPI_ERROR_USER + 0x05);
        public const int ACAMAPI_ERROR_ADMINNOTFOUND = (ACAMAPI_ERROR_USER + 0x06);
        public const int ACAMAPI_ERROR_USERNOTADMIN = (ACAMAPI_ERROR_USER + 0x07);
        public const int ACAMAPI_ERROR_INVALID_FPLEN = (ACAMAPI_ERROR_USER + 0x08);



        // ################################################################################################
        //	   Definition of errors for group information.
        // ################################################################################################
        public const int ACAMAPI_ERROR_GROUPLISTNOTOPEN = (ACAMAPI_ERROR_GROUP + 0x01);



        // ################################################################################################
        //	   Definition of errors for node information.
        // ################################################################################################
        public const int ACAMAPI_ERROR_NODELISTNOTOPEN = (ACAMAPI_ERROR_NODE + 0x01);
        public const int ACAMAPI_ERROR_INVALIDIMAGEFORMAT = (ACAMAPI_ERROR_NODE + 0x02);
        public const int ACAMAPI_ERROR_INVALIDIMAGEDATA = (ACAMAPI_ERROR_NODE + 0X03);



        // ################################################################################################
        //	   Definition of errors for system event log.
        // ################################################################################################
        public const int ACAMAPI_ERROR_SYSLOGLISTNOTOPEN = (ACAMAPI_ERROR_SYSEVENT + 0x01);



        // ################################################################################################
        //	   Definition of errors for login event log.
        // ################################################################################################
        public const int ACAMAPI_ERROR_LOGINLISTNOTOPEN = (ACAMAPI_ERROR_LOGINEVENT + 0x01);



        // ################################################################################################
        //	   Definition of errors for server information.
        // ################################################################################################
        public const int ACAMAPI_ERROR_SERVERCONNECTED = (ACAMAPI_ERROR_SERVER + 0x01);
        public const int ACAMAPI_ERROR_SERVERNORMAL = (ACAMAPI_ERROR_SERVER + 0x02);



        // ################################################################################################
        //	   Definition of errors for dbsvragent information.
        // ################################################################################################
        public const int ACAMAPI_ERROR_DBSVRAGENTCONNECTED = (ACAMAPI_ERROR_DBSVRAGENT + 0x01);
        public const int ACAMAPI_ERROR_DBSVRAGENTNOTCONNECTED = (ACAMAPI_ERROR_DBSVRAGENT + 0x02);
        public const int ACAMAPI_ERROR_DBSVRAGENTNOTCONNECTFAIL = (ACAMAPI_ERROR_DBSVRAGENT + 0x03);
        public const int ACAMAPI_ERROR_DBSVRAGENTVERSION = (ACAMAPI_ERROR_DBSVRAGENT + 0x04);


        // ################################################################################################
        //	   Definition of errors for privilege information.
        // ################################################################################################
        public const int ACAMAPI_ERROR_PRIVILEGEMASTER = (ACAMAPI_ERROR_PRIVILEGE + 0x01);

        public const int ACAMAPI_ERROR_PRIVILEGEUSERADD = (ACAMAPI_ERROR_PRIVILEGE + 0x02);
        public const int ACAMAPI_ERROR_PRIVILEGEUSERDEL = (ACAMAPI_ERROR_PRIVILEGE + 0x03);
        public const int ACAMAPI_ERROR_PRIVILEGEUSERMODIFY = (ACAMAPI_ERROR_PRIVILEGE + 0x04);
        public const int ACAMAPI_ERROR_PRIVILEGEGETUSER = (ACAMAPI_ERROR_PRIVILEGE + 0x05);

        public const int ACAMAPI_ERROR_PRIVILEGEGROUPADD = (ACAMAPI_ERROR_PRIVILEGE + 0x06);
        public const int ACAMAPI_ERROR_PRIVILEGEGROUPDEL = (ACAMAPI_ERROR_PRIVILEGE + 0x07);
        public const int ACAMAPI_ERROR_PRIVILEGEGROUPMODIFY = (ACAMAPI_ERROR_PRIVILEGE + 0x08);
        public const int ACAMAPI_ERROR_PRIVILEGEGETGROUP = (ACAMAPI_ERROR_PRIVILEGE + 0x09);

        public const int ACAMAPI_ERROR_PRIVILEGENODEADD = (ACAMAPI_ERROR_PRIVILEGE + 0x0a);
        public const int ACAMAPI_ERROR_PRIVILEGENODEDEL = (ACAMAPI_ERROR_PRIVILEGE + 0x0b);
        public const int ACAMAPI_ERROR_PRIVILEGENODEMODIFY = (ACAMAPI_ERROR_PRIVILEGE + 0x0c);
        public const int ACAMAPI_ERROR_PRIVILEGEGETNODE = (ACAMAPI_ERROR_PRIVILEGE + 0x0d);
        public const int ACAMAPI_ERROR_PRIVILEGENODEUSER = (ACAMAPI_ERROR_PRIVILEGE + 0x0e);
        public const int ACAMAPI_ERROR_PRIVILEGEGATE = (ACAMAPI_ERROR_PRIVILEGE + 0x0f);

        public const int ACAMAPI_ERROR_PRIVILEGEGETSYSLOG = (ACAMAPI_ERROR_PRIVILEGE + 0x10);
        public const int ACAMAPI_ERROR_PRIVILEGEGETLOG = (ACAMAPI_ERROR_PRIVILEGE + 0x11);


        // ################################################################################################
        //	   Definition of errors for the custom message informations.
        // ################################################################################################
        public const int ACAMAPI_ERROR_INVALID_CHARACTER = (ACAMAPI_ERROR_CUSTOM_MESSAGE + 0x01);
        public const int ACAMAPI_ERROR_EXCEED_LINE_NUM = (ACAMAPI_ERROR_CUSTOM_MESSAGE + 0x02);
        public const int ACAMAPI_ERROR_MESSAGE_DUPLICATED = (ACAMAPI_ERROR_CUSTOM_MESSAGE + 0x03);


        // ################################################################################################
        //	   Definition of errors for the Update firmware.
        // ################################################################################################
        public const int ACAMAPI_ERROR_INVALID_FIRMWARE = (ACAMAPI_ERROR_FIRMWARE + 0x01);
        public const int ACAMAPI_ERROR_INVALID_FWPATH = (ACAMAPI_ERROR_FIRMWARE + 0x02);
        public const int ACAMAPI_ERROR_INVALID_FWTYPE = (ACAMAPI_ERROR_FIRMWARE + 0x03);


        // Category of error
        public const int ACSERVER_ERROR_GENERAL = (0x30010000);

        // ################################################################################################
        //	   Definition of errors for general status.
        // ################################################################################################

        public const int ACSERVER_ERROR_ADMINNOTFOUND = (ACSERVER_ERROR_GENERAL + 0x01);
        public const int ACSERVER_ERROR_NBIOAPI = (ACSERVER_ERROR_GENERAL + 0x02);
        public const int ACSERVER_ERROR_INVALIDBACKUPPATH = (ACSERVER_ERROR_GENERAL + 0x03);
        public const int ACSERVER_ERROR_INVALIDLOGTEXT = (ACSERVER_ERROR_GENERAL + 0x04);
        public const int ACSERVER_ERROR_INVALIDUSERIDLEN = (ACSERVER_ERROR_GENERAL + 0x05);
        public const int ACSERVER_ERROR_INVALIDUSERIDLEN_2 = (ACSERVER_ERROR_GENERAL + 0x06);
        public const int ACSERVER_ERROR_INVALIDFINGERCNT = (ACSERVER_ERROR_GENERAL + 0x07);
        public const int ACSERVER_ERROR_INVALIDFINGERCNT_2 = (ACSERVER_ERROR_GENERAL + 0x08);
        public const int ACSERVER_ERROR_INVALIDLOGAGE = (ACSERVER_ERROR_GENERAL + 0x09);
        public const int ACSERVER_ERROR_INVALIDBACKUPCYCLE = (ACSERVER_ERROR_GENERAL + 0x0a);
        public const int ACSERVER_ERROR_INVALIDBACKUPTIME = (ACSERVER_ERROR_GENERAL + 0x0b);
        public const int ACSERVER_ERROR_NODEUSERNOTEMPTY = (ACSERVER_ERROR_GENERAL + 0x0c);
        public const int ACSERVER_ERROR_USERNOTFOUND = (ACSERVER_ERROR_GENERAL + 0x0d);
        public const int ACSERVER_ERROR_DBBACKUPFAIL = (ACSERVER_ERROR_GENERAL + 0x0e);
        public const int ACSERVER_ERROR_USERSTOP = (ACSERVER_ERROR_GENERAL + 0x0f);
        public const int ACSERVER_ERROR_LOCKED_MEM = (ACSERVER_ERROR_GENERAL + 0x10);
        public const int ACSERVER_ERROR_INVALIDTIMEZONE = (ACSERVER_ERROR_GENERAL + 0x11);
        public const int ACSERVER_ERROR_INVALIDRMVERSION = (ACSERVER_ERROR_GENERAL + 0x12);
        public const int ACSERVER_ERROR_NOT_SUPPORTED = (ACSERVER_ERROR_GENERAL + 0x13);
        public const int ACSERVER_ERROR_INVALID_IDENTIFYTIMEOUT = (ACSERVER_ERROR_GENERAL + 0x14);
        public const int ACSERVER_ERROR_INVALID_CHECKFP = (ACSERVER_ERROR_GENERAL + 0x15);
        public const int ACSERVER_ERROR_SERVER_BUSY = (ACSERVER_ERROR_GENERAL + 0x16);
        public const int ACSERVER_ERROR_DB_ERROR = (ACSERVER_ERROR_GENERAL + 0x17);
        public const int ACSERVER_ERROR_INVALIDTEMPLATECNT = (ACSERVER_ERROR_GENERAL + 0x18);
        public const int ACSERVER_ERROR_TERMINAL_NOT_CONNECTED = (ACSERVER_ERROR_GENERAL + 0x19);
        public const int ACSERVER_ERROR_ALREADY_LOGIN = (ACSERVER_ERROR_GENERAL + 0x20);
        public const int ACSERVER_ERROR_NOT_LOGIN = (ACSERVER_ERROR_GENERAL + 0x21);
        public const int ACSERVER_ERROR_TIMEOUT = (ACSERVER_ERROR_GENERAL + 0x22);
        public const int ACSERVER_ERROR_INVALID_AUTHTYPE = (ACSERVER_ERROR_GENERAL + 0x23);
        public const int ACSERVER_ERROR_MEMORY_FULL = (ACSERVER_ERROR_GENERAL + 0x24);
        public const int ACSERVER_ERROR_SYNC_FAIL = (ACSERVER_ERROR_GENERAL + 0x25);

        public const int ACSERVER_ERROR_INVALID_PARAM_IP = (ACSERVER_ERROR_GENERAL + 0x50);
        public const int ACSERVER_ERROR_INVALID_PARAM_ID = (ACSERVER_ERROR_GENERAL + 0x51);
        public const int ACSERVER_ERROR_INVALID_PARAM_PWD = (ACSERVER_ERROR_GENERAL + 0x52);

    }
}
