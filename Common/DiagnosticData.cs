using System;
using System.Collections.Generic;
using System.Text;

namespace DataMonitor.Common
{
    public class DiagnosticData
    {
        private decimal amp;

        public decimal Amp
        {
            get { return amp; }
            set { amp = value; }
        }
        private DateTime timestamp;

        public DateTime Timestamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
        
        private Int64 sequenceNumber;

        public Int64 SequenceNumber
        {
            get { return sequenceNumber; }
            set { sequenceNumber = value; }
        }

        public override string ToString()
        {
            return string.Format("[2]\t{0}: {1}",Timestamp,Amp,SequenceNumber);
        }
    }
}
