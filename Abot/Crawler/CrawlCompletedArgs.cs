﻿using Abot.Poco;
using System;

namespace Abot.Crawler
{
    /// <summary>
    /// 抓取结果类
    /// </summary>
    [Serializable]
    public class CrawlCompletedArgs : CrawlArgs
    {
        /// <summary>
        /// 抓取结果
        /// </summary>
        public CrawlResult Result { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="crawlContext">上下文</param>
        /// <param name="crawlResult">抓取结果</param>
        public CrawlCompletedArgs(CrawlContext crawlContext, CrawlResult crawlResult)
            : base(crawlContext)
        {
            if (crawlResult == null)
                throw new ArgumentNullException("crawlResult");

            Result = crawlResult;
        }
    }
}
