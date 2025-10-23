// This is a generated file.  Don't edit it directly!

using System;
using QuickFix.Fields;

namespace QuickFix.FIX50SP2;

public class MarketDataSnapshotFullRefresh : Message
{
    public const string MsgType = "W";

    public MarketDataSnapshotFullRefresh() : base()
    {
        Header.SetField(new MsgType("W"));
    }

    public MarketDataSnapshotFullRefresh(
            LastUpdateTime aLastUpdateTime
        ) : this()
    {
        LastUpdateTime = aLastUpdateTime;
    }

    public MarketDepth MarketDepth
    {
        get
        {
            MarketDepth val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MarketDepth val) { MarketDepth = val; }
    public MarketDepth Get(MarketDepth val) { GetField(val); return val; }
    public bool IsSet(MarketDepth val) { return IsSetMarketDepth(); }
    public bool IsSetMarketDepth() { return IsSetField(Tags.MarketDepth); }

    public MDReqID MDReqID
    {
        get
        {
            MDReqID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(MDReqID val) { MDReqID = val; }
    public MDReqID Get(MDReqID val) { GetField(val); return val; }
    public bool IsSet(MDReqID val) { return IsSetMDReqID(); }
    public bool IsSetMDReqID() { return IsSetField(Tags.MDReqID); }

    public Symbol Symbol
    {
        get
        {
            Symbol val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Symbol val) { Symbol = val; }
    public Symbol Get(Symbol val) { GetField(val); return val; }
    public bool IsSet(Symbol val) { return IsSetSymbol(); }
    public bool IsSetSymbol() { return IsSetField(Tags.Symbol); }

    public SecurityID SecurityID
    {
        get
        {
            SecurityID val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityID val) { SecurityID = val; }
    public SecurityID Get(SecurityID val) { GetField(val); return val; }
    public bool IsSet(SecurityID val) { return IsSetSecurityID(); }
    public bool IsSetSecurityID() { return IsSetField(Tags.SecurityID); }

    public SecurityIDSource SecurityIDSource
    {
        get
        {
            SecurityIDSource val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityIDSource val) { SecurityIDSource = val; }
    public SecurityIDSource Get(SecurityIDSource val) { GetField(val); return val; }
    public bool IsSet(SecurityIDSource val) { return IsSetSecurityIDSource(); }
    public bool IsSetSecurityIDSource() { return IsSetField(Tags.SecurityIDSource); }

    public Currency Currency
    {
        get
        {
            Currency val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(Currency val) { Currency = val; }
    public Currency Get(Currency val) { GetField(val); return val; }
    public bool IsSet(Currency val) { return IsSetCurrency(); }
    public bool IsSetCurrency() { return IsSetField(Tags.Currency); }

    public SecurityExchange SecurityExchange
    {
        get
        {
            SecurityExchange val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(SecurityExchange val) { SecurityExchange = val; }
    public SecurityExchange Get(SecurityExchange val) { GetField(val); return val; }
    public bool IsSet(SecurityExchange val) { return IsSetSecurityExchange(); }
    public bool IsSetSecurityExchange() { return IsSetField(Tags.SecurityExchange); }

    public NoMDEntries NoMDEntries
    {
        get
        {
            NoMDEntries val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(NoMDEntries val) { NoMDEntries = val; }
    public NoMDEntries Get(NoMDEntries val) { GetField(val); return val; }
    public bool IsSet(NoMDEntries val) { return IsSetNoMDEntries(); }
    public bool IsSetNoMDEntries() { return IsSetField(Tags.NoMDEntries); }

    public LastUpdateTime LastUpdateTime
    {
        get
        {
            LastUpdateTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(LastUpdateTime val) { LastUpdateTime = val; }
    public LastUpdateTime Get(LastUpdateTime val) { GetField(val); return val; }
    public bool IsSet(LastUpdateTime val) { return IsSetLastUpdateTime(); }
    public bool IsSetLastUpdateTime() { return IsSetField(Tags.LastUpdateTime); }

    public TransactTime TransactTime
    {
        get
        {
            TransactTime val = new();
            GetField(val);
            return val;
        }
        set  => SetField(value);
    }

    public void Set(TransactTime val) { TransactTime = val; }
    public TransactTime Get(TransactTime val) { GetField(val); return val; }
    public bool IsSet(TransactTime val) { return IsSetTransactTime(); }
    public bool IsSetTransactTime() { return IsSetField(Tags.TransactTime); }

    public class NoMDEntriesGroup : Group
    {
        public static int[] DefaultFieldOrder = [Tags.MDEntryType, Tags.MDEntryPx, Tags.OrdType, Tags.MDEntrySize, Tags.MDEntryDate, Tags.MDEntryTime, Tags.TradeCondition, Tags.OpenCloseSettlFlag, Tags.OrderID, Tags.QuoteEntryID, Tags.TradeID, Tags.Text, 0];

        [Obsolete("Use DefaultFieldOrder instead.  This will be removed in a future release.")]
        public static int[] fieldOrder = {Tags.MDEntryType, Tags.MDEntryPx, Tags.OrdType, Tags.MDEntrySize, Tags.MDEntryDate, Tags.MDEntryTime, Tags.TradeCondition, Tags.OpenCloseSettlFlag, Tags.OrderID, Tags.QuoteEntryID, Tags.TradeID, Tags.Text, 0};

        public NoMDEntriesGroup()
          : base(Tags.NoMDEntries, Tags.MDEntryType, DefaultFieldOrder)
        {
        }

        public override Group Clone()
        {
            var clone = new NoMDEntriesGroup();
            clone.CopyStateFrom(this);
            return clone;
        }

        public MDEntryType MDEntryType
        {
            get
            {
                MDEntryType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryType val) { MDEntryType = val; }
        public MDEntryType Get(MDEntryType val) { GetField(val); return val; }
        public bool IsSet(MDEntryType val) { return IsSetMDEntryType(); }
        public bool IsSetMDEntryType() { return IsSetField(Tags.MDEntryType); }

        public MDEntryPx MDEntryPx
        {
            get
            {
                MDEntryPx val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryPx val) { MDEntryPx = val; }
        public MDEntryPx Get(MDEntryPx val) { GetField(val); return val; }
        public bool IsSet(MDEntryPx val) { return IsSetMDEntryPx(); }
        public bool IsSetMDEntryPx() { return IsSetField(Tags.MDEntryPx); }

        public OrdType OrdType
        {
            get
            {
                OrdType val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrdType val) { OrdType = val; }
        public OrdType Get(OrdType val) { GetField(val); return val; }
        public bool IsSet(OrdType val) { return IsSetOrdType(); }
        public bool IsSetOrdType() { return IsSetField(Tags.OrdType); }

        public MDEntrySize MDEntrySize
        {
            get
            {
                MDEntrySize val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntrySize val) { MDEntrySize = val; }
        public MDEntrySize Get(MDEntrySize val) { GetField(val); return val; }
        public bool IsSet(MDEntrySize val) { return IsSetMDEntrySize(); }
        public bool IsSetMDEntrySize() { return IsSetField(Tags.MDEntrySize); }

        public MDEntryDate MDEntryDate
        {
            get
            {
                MDEntryDate val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryDate val) { MDEntryDate = val; }
        public MDEntryDate Get(MDEntryDate val) { GetField(val); return val; }
        public bool IsSet(MDEntryDate val) { return IsSetMDEntryDate(); }
        public bool IsSetMDEntryDate() { return IsSetField(Tags.MDEntryDate); }

        public MDEntryTime MDEntryTime
        {
            get
            {
                MDEntryTime val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(MDEntryTime val) { MDEntryTime = val; }
        public MDEntryTime Get(MDEntryTime val) { GetField(val); return val; }
        public bool IsSet(MDEntryTime val) { return IsSetMDEntryTime(); }
        public bool IsSetMDEntryTime() { return IsSetField(Tags.MDEntryTime); }

        public TradeCondition TradeCondition
        {
            get
            {
                TradeCondition val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradeCondition val) { TradeCondition = val; }
        public TradeCondition Get(TradeCondition val) { GetField(val); return val; }
        public bool IsSet(TradeCondition val) { return IsSetTradeCondition(); }
        public bool IsSetTradeCondition() { return IsSetField(Tags.TradeCondition); }

        public OpenCloseSettlFlag OpenCloseSettlFlag
        {
            get
            {
                OpenCloseSettlFlag val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OpenCloseSettlFlag val) { OpenCloseSettlFlag = val; }
        public OpenCloseSettlFlag Get(OpenCloseSettlFlag val) { GetField(val); return val; }
        public bool IsSet(OpenCloseSettlFlag val) { return IsSetOpenCloseSettlFlag(); }
        public bool IsSetOpenCloseSettlFlag() { return IsSetField(Tags.OpenCloseSettlFlag); }

        public OrderID OrderID
        {
            get
            {
                OrderID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(OrderID val) { OrderID = val; }
        public OrderID Get(OrderID val) { GetField(val); return val; }
        public bool IsSet(OrderID val) { return IsSetOrderID(); }
        public bool IsSetOrderID() { return IsSetField(Tags.OrderID); }

        public QuoteEntryID QuoteEntryID
        {
            get
            {
                QuoteEntryID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(QuoteEntryID val) { QuoteEntryID = val; }
        public QuoteEntryID Get(QuoteEntryID val) { GetField(val); return val; }
        public bool IsSet(QuoteEntryID val) { return IsSetQuoteEntryID(); }
        public bool IsSetQuoteEntryID() { return IsSetField(Tags.QuoteEntryID); }

        public TradeID TradeID
        {
            get
            {
                TradeID val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(TradeID val) { TradeID = val; }
        public TradeID Get(TradeID val) { GetField(val); return val; }
        public bool IsSet(TradeID val) { return IsSetTradeID(); }
        public bool IsSetTradeID() { return IsSetField(Tags.TradeID); }

        public Text Text
        {
            get
            {
                Text val = new();
                GetField(val);
                return val;
            }
            set  => SetField(value);
        }

        public void Set(Text val) { Text = val; }
        public Text Get(Text val) { GetField(val); return val; }
        public bool IsSet(Text val) { return IsSetText(); }
        public bool IsSetText() { return IsSetField(Tags.Text); }
    }
}
