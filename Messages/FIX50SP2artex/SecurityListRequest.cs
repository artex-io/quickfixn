// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class SecurityListRequest : Message
{
    public const string MsgType = "x";

    public SecurityListRequest() : base()
    {
        Header.SetField(new MsgType("x"));
    }

    public SecurityListRequest(
            SecurityReqID aSecurityReqID,
            SecurityListRequestType aSecurityListRequestType
        ) : this()
    {
        SecurityReqID = aSecurityReqID;
        SecurityListRequestType = aSecurityListRequestType;
    }

    public SecurityReqID SecurityReqID
    {
        get
        {
            SecurityReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityReqID val) { SecurityReqID = val; }
    public SecurityReqID Get(SecurityReqID val) { GetField(val); return val; }
    public bool IsSet(SecurityReqID val) { return IsSetSecurityReqID(); }
    public bool IsSetSecurityReqID() { return IsSetField(Tags.SecurityReqID); }

    public SecurityListRequestType SecurityListRequestType
    {
        get
        {
            SecurityListRequestType val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityListRequestType val) { SecurityListRequestType = val; }
    public SecurityListRequestType Get(SecurityListRequestType val) { GetField(val); return val; }
    public bool IsSet(SecurityListRequestType val) { return IsSetSecurityListRequestType(); }
    public bool IsSetSecurityListRequestType() { return IsSetField(Tags.SecurityListRequestType); }
}
