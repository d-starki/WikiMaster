﻿using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WikiMaster.ExternalAPIs.Wikipedia
{
    public class WikipediaData
    {
        private WikipediaAPI wikipediaApi;
        public RootWikipediaRandomArticle randomArticle;

        public WikipediaData(string language = "en")
        {
            wikipediaApi = new WikipediaAPI(language);
        }

        public async Task<RootWikipediaRandomArticle> GetRandomArticle()
        {
            string jsonArticle = await wikipediaApi.RandomArticleSummaryRequest();
            randomArticle = JsonConvert.DeserializeObject<RootWikipediaRandomArticle>(jsonArticle);
            return randomArticle;
        }
    }
}
