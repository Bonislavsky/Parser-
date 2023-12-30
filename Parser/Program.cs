using AngleSharp;
using System.Net;
using System.Text.Json;

namespace Parser
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var proxy = new WebProxy("127.0.0.1:8866");
            var cookieContainer = new CookieContainer();
            // это пример как должно было бы выглядить запрос ко второй вкладке для получения 60 продуктов.

            // при запросе к выбранной вкладке продуктов ( к примеру medicamenti) мы можем узнать сколько всего вкладок продуктов по 60 на странице
            // и уже зная общее количество задать нужно количество вызовов подобных тех что ниже

            // подобным образом можно было бы обойти все остальные варианты продукции
            var getRequestMain = new GetRequest($"https://www.add.ua/medicamenti/?p=2");
            getRequestMain.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7";
            getRequestMain.Useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
            getRequestMain.Host = "www.add.ua";
            getRequestMain.Proxy = proxy;
            getRequestMain.Run(cookieContainer);

            var postRequestSupport1 = new PostRequest("https://www.add.ua/cdn-cgi/rum?");
            postRequestSupport1.Data = "{{\"memory\":{{\"totalJSHeapSize\":22937362,\"usedJSHeapSize\":13986802,\"jsHeapSizeLimit\":4294705152}},\"resources\":[],\"referrer\":\"\",\"eventType\":1,\"firstPaint\":5204.399999991059,\"firstContentfulPaint\":5204.399999991059,\"startTime\":1703863934551,\"versions\":{{\"fl\":\"2023.10.0\",\"js\":\"2023.10.0\",\"timings\":2}},\"pageloadId\":\"3c247d38-20be-4474-ace2-d8d46855b578\",\"location\":\"https://www.add.ua/ua/medicamenti/\",\"timingsV2\":{{\"unloadEventStart\":5108.79999999702,\"unloadEventEnd\":5108.79999999702,\"domInteractive\":5351.399999991059,\"domContentLoadedEventStart\":5353.79999999702,\"domContentLoadedEventEnd\":5795.70000000298,\"domComplete\":7348.29999999702,\"loadEventStart\":7351.0999999940395,\"loadEventEnd\":7422.20000000298,\"type\":\"reload\",\"redirectCount\":0,\"criticalCHRestart\":0,\"activationStart\":0,\"initiatorType\":\"navigation\",\"nextHopProtocol\":\"h2\",\"deliveryType\":\"\",\"workerStart\":0,\"redirectStart\":0,\"redirectEnd\":0,\"fetchStart\":1.0999999940395355,\"domainLookupStart\":1.0999999940395355,\"domainLookupEnd\":1.0999999940395355,\"connectStart\":2.7000000029802322,\"connectEnd\":378,\"secureConnectionStart\":374.79999999701977,\"requestStart\":378.20000000298023,\"responseStart\":5056,\"responseEnd\":5134.79999999702,\"transferSize\":146356,\"encodedBodySize\":146056,\"decodedBodySize\":2688192,\"serverTiming\":[],\"renderBlockingStatus\":\"non-blocking\",\"responseStatus\":200,\"firstInterimResponseStart\":0,\"name\":\"https://www.add.ua/ua/medicamenti/?p=2\",\"entryType\":\"navigation\",\"startTime\":0,\"duration\":7422.20000000298}},\"siteToken\":\"beb23b2551c54b69b8b23a49e9ff2382\",\"st\":2}}";
            postRequestSupport1.Accept = "*/*";
            postRequestSupport1.Useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
            postRequestSupport1.ContentType = "application/json";
            postRequestSupport1.Referer = "https://www.add.ua/ua/medicamenti/?p=2";
            postRequestSupport1.Host = "www.add.ua";
            postRequestSupport1.Proxy = proxy;
            postRequestSupport1.Run(cookieContainer);

            var getRequestSupport = new GetRequest($"https://www.add.ua/sw.js");
            getRequestSupport.Accept = "*/*";
            getRequestSupport.Useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
            getRequestSupport.Host = "www.add.ua";
            getRequestSupport.Proxy = proxy;
            getRequestSupport.Run(cookieContainer);

            var postRequestSupport2 = new PostRequest("https://www.add.ua/cdn-cgi/rum?");
            postRequestSupport2.Data = "{{\"referrer\":\"\",\"eventType\":3,\"versions\":{{\"js\":\"2023.10.0\",\"fl\":\"2023.10.0\"}},\"pageloadId\":\"5a3270f2-619d-48c8-b48e-216d8561598d\",\"location\":\"https://www.add.ua/ua/medicamenti/\",\"landingPath\":\"/ua/medicamenti/\",\"startTime\":1703864993474.7,\"siteToken\":\"beb23b2551c54b69b8b23a49e9ff2382\",\"lcp\":{{\"value\":5098.100000008941,\"path\":\"/ua/medicamenti/\",\"element\":\"span.product-image-container.jpg>span.product-image-wrapper>picture>img.product-image-photo.\",\"size\":62500,\"url\":\"https://www.add.ua/media/catalog/product/cache/19343e866f5b15e8e8a3a38202601740/1/0/1000-_-120_jpg.webp\",\"rld\":60.599999994039536,\"rlt\":0,\"erd\":108.6000000089407,\"it\":\"img\",\"fp\":null}},\"fid\":{{\"value\":-1}},\"cls\":{{\"value\":0.000387991013691509,\"path\":\"/ua/medicamenti/\",\"element\":\"div.page-wrapper>header.page-header>div.header-banner>a>span>strong>center\",\"currentRect\":{{\"x\":332,\"y\":9,\"width\":247,\"height\":15,\"top\":9,\"right\":579,\"bottom\":24,\"left\":332}},\"previousRect\":{{\"x\":341,\"y\":9,\"width\":247,\"height\":15,\"top\":9,\"right\":588,\"bottom\":24,\"left\":341},\"fcp\":{{\"value\":5048.100000008941,\"path\":\"/ua/medicamenti/\"}},\"ttfb\":{{\"value\":4928.9000000059605,\"path\":\"/ua/medicamenti/\"}},\"inp\":{{\"value\":-1}},\"timingsV2\":{{\"nextHopProtocol\":\"h2\"}},\"st\":1}}}}}";
            postRequestSupport2.Accept = "*/*";
            postRequestSupport2.Useragent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36";
            postRequestSupport2.ContentType = "application/json";
            postRequestSupport2.Referer = "https://www.add.ua/ua/medicamenti/?p=2";
            postRequestSupport2.Host = "www.add.ua";
            postRequestSupport2.Proxy = proxy;
            postRequestSupport2.Run(cookieContainer);

            var products = HtmlParser.ParseHtml(getRequestMain.Response);

            string jsonString = JsonSerializer.Serialize(products);

            using (StreamWriter writer = new StreamWriter("products.json"))
            {
                writer.Write(jsonString);
            }
        }
    }
}
