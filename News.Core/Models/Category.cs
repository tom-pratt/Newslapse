﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace News.Core
{
    [DataContract]
    public class Category : BaseCategory
    {
        [DataMember(Name = "Items")]
        public IList<ArticleSummary> ArticleSummaries { get; set; }
    }

    [DataContract]
    public class CategorySummary : BaseCategory
    {
    }

    [DataContract]
    public abstract class BaseCategory
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string DisplayUrl { get; set; }
    }
}
