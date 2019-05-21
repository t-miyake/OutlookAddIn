﻿using CsvHelper.Configuration;

namespace OutlookOkan.Types
{
    public sealed class AutoCcBccAttachedFile
    {
        public CcOrBcc CcOrBcc { get; set; }
        public string AutoAddAddress { get; set; }
    }

    public sealed class AutoCcBccAttachedFileMap : ClassMap<AutoCcBccAttachedFile>
    {
        public AutoCcBccAttachedFileMap()
        {
            Map(m => m.CcOrBcc).Index(0);
            Map(m => m.AutoAddAddress).Index(1);
        }
    }
}