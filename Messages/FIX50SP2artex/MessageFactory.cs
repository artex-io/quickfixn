// This is a generated file.  Don't edit it directly!

using System.Collections.Generic;
using QuickFix.FixValues;

namespace QuickFix.FIX50SP2;

public class MessageFactory : IMessageFactory
{
    public ICollection<string> GetSupportedBeginStrings()
    {
       return new [] { BeginString.FIX50SP2 };
    }

    public QuickFix.Message Create(string beginString, QuickFix.Fields.ApplVerID applVerId, string msgType)
    {
        return Create(beginString, msgType);
    }

    public QuickFix.Message Create(string beginString, string msgType)
    {
        return msgType switch
        {
            QuickFix.FIX50SP2.ExecutionReport.MsgType => new QuickFix.FIX50SP2.ExecutionReport(),
            QuickFix.FIX50SP2.OrderCancelReject.MsgType => new QuickFix.FIX50SP2.OrderCancelReject(),
            QuickFix.FIX50SP2.News.MsgType => new QuickFix.FIX50SP2.News(),
            QuickFix.FIX50SP2.NewOrderSingle.MsgType => new QuickFix.FIX50SP2.NewOrderSingle(),
            QuickFix.FIX50SP2.OrderCancelRequest.MsgType => new QuickFix.FIX50SP2.OrderCancelRequest(),
            QuickFix.FIX50SP2.OrderCancelReplaceRequest.MsgType => new QuickFix.FIX50SP2.OrderCancelReplaceRequest(),
            QuickFix.FIX50SP2.OrderStatusRequest.MsgType => new QuickFix.FIX50SP2.OrderStatusRequest(),
            QuickFix.FIX50SP2.Quote.MsgType => new QuickFix.FIX50SP2.Quote(),
            QuickFix.FIX50SP2.MarketDataRequest.MsgType => new QuickFix.FIX50SP2.MarketDataRequest(),
            QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.MsgType => new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh(),
            QuickFix.FIX50SP2.MarketDataIncrementalRefresh.MsgType => new QuickFix.FIX50SP2.MarketDataIncrementalRefresh(),
            QuickFix.FIX50SP2.MarketDataRequestReject.MsgType => new QuickFix.FIX50SP2.MarketDataRequestReject(),
            QuickFix.FIX50SP2.QuoteCancel.MsgType => new QuickFix.FIX50SP2.QuoteCancel(),
            QuickFix.FIX50SP2.QuoteStatusRequest.MsgType => new QuickFix.FIX50SP2.QuoteStatusRequest(),
            QuickFix.FIX50SP2.SecurityStatus.MsgType => new QuickFix.FIX50SP2.SecurityStatus(),
            QuickFix.FIX50SP2.SecurityStatusRequest.MsgType => new QuickFix.FIX50SP2.SecurityStatusRequest(),
            QuickFix.FIX50SP2.BusinessMessageReject.MsgType => new QuickFix.FIX50SP2.BusinessMessageReject(),
            QuickFix.FIX50SP2.OrderMassCancelRequest.MsgType => new QuickFix.FIX50SP2.OrderMassCancelRequest(),
            QuickFix.FIX50SP2.OrderMassCancelReport.MsgType => new QuickFix.FIX50SP2.OrderMassCancelReport(),
            QuickFix.FIX50SP2.SecurityListRequest.MsgType => new QuickFix.FIX50SP2.SecurityListRequest(),
            QuickFix.FIX50SP2.SecurityList.MsgType => new QuickFix.FIX50SP2.SecurityList(),
            QuickFix.FIX50SP2.OrderMassStatusRequest.MsgType => new QuickFix.FIX50SP2.OrderMassStatusRequest(),
            QuickFix.FIX50SP2.QuoteStatusReport.MsgType => new QuickFix.FIX50SP2.QuoteStatusReport(),
            _ => new QuickFix.Message()
        };
    }

    public Group? Create(string beginString, string msgType, int correspondingFieldId)
    {
        if (QuickFix.FIX50SP2.ExecutionReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.ExecutionReport.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.OrderCancelReject.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelReject.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelReject.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.News.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.News.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoLinesOfText: return new QuickFix.FIX50SP2.News.NoLinesOfTextGroup();
            }
        }

        if (QuickFix.FIX50SP2.NewOrderSingle.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.NewOrderSingle.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.OrderCancelRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.OrderCancelReplaceRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderCancelReplaceRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.OrderStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.Quote.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.Quote.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.Quote.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.MarketDataRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntryTypes: return new QuickFix.FIX50SP2.MarketDataRequest.NoMDEntryTypesGroup();
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.MarketDataRequest.NoRelatedSymGroup();
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MarketDataRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataSnapshotFullRefresh.NoMDEntriesGroup();
            }
        }

        if (QuickFix.FIX50SP2.MarketDataIncrementalRefresh.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoMDEntries: return new QuickFix.FIX50SP2.MarketDataIncrementalRefresh.NoMDEntriesGroup();
            }
        }

        if (QuickFix.FIX50SP2.MarketDataRequestReject.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.MarketDataRequestReject.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.QuoteCancel.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteCancel.NoPartyIDsGroup.NoPartySubIDsGroup();
                case QuickFix.Fields.Tags.NoQuoteEntries: return new QuickFix.FIX50SP2.QuoteCancel.NoQuoteEntriesGroup();
            }
        }

        if (QuickFix.FIX50SP2.QuoteStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.OrderMassCancelRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.OrderMassCancelReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassCancelReport.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.SecurityList.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoRelatedSym: return new QuickFix.FIX50SP2.SecurityList.NoRelatedSymGroup();
            }
        }

        if (QuickFix.FIX50SP2.OrderMassStatusRequest.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.OrderMassStatusRequest.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        if (QuickFix.FIX50SP2.QuoteStatusReport.MsgType.Equals(msgType))
        {
            switch (correspondingFieldId)
            {
                case QuickFix.Fields.Tags.NoPartyIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoPartyIDsGroup();
                case QuickFix.Fields.Tags.NoPartySubIDs: return new QuickFix.FIX50SP2.QuoteStatusReport.NoPartyIDsGroup.NoPartySubIDsGroup();
            }
        }

        return null;
    }
}
