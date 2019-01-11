using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Weather
    {
        //{
//	"resultcode":"200",
//	"reason":"查询成功",
//	"result":{
//		"sk":{
//			"temp":"6",
//			"wind_direction":"西北风",
//			"wind_strength":"3级",
//			"humidity":"99%",
//			"time":"11:01"
//		},
//		"today":{
//			"temperature":"8℃~10℃",
//			"weather":"小雨-中雨转阴",
//			"weather_id":{
//				"fa":"21",
//				"fb":"02"
//			},
//			"wind":"北风微风",
//			"week":"星期五",
//			"city":"柳州",
//			"date_y":"2019年01月11日",
//			"dressing_index":"较冷",
//			"dressing_advice":"建议着厚外套加毛衣等服装。年老体弱者宜着大衣、呢外套加羊毛衫。",
//			"uv_index":"最弱",
//			"comfort_index":"",
//			"wash_index":"不宜",
//			"travel_index":"较不宜",
//			"exercise_index":"较不宜",
//			"drying_index":""
//		},
//		"future":{
//			"day_20190111":{
//				"temperature":"8℃~10℃",
//				"weather":"小雨-中雨转阴",
//				"weather_id":{
//					"fa":"21",
//					"fb":"02"
//				},
//				"wind":"北风微风",
//				"week":"星期五",
//				"date":"20190111"
//			},
//			"day_20190112":{
//				"temperature":"10℃~13℃",
//				"weather":"阴转小雨",
//				"weather_id":{
//					"fa":"02",
//					"fb":"07"
//				},
//				"wind":"北风微风",
//				"week":"星期六",
//				"date":"20190112"
//			},
//			"day_20190113":{
//				"temperature":"10℃~13℃",
//				"weather":"小雨",
//				"weather_id":{
//					"fa":"07",
//					"fb":"07"
//				},
//				"wind":"北风微风",
//				"week":"星期日",
//				"date":"20190113"
//			},
//			"day_20190114":{
//				"temperature":"9℃~14℃",
//				"weather":"小雨",
//				"weather_id":{
//					"fa":"07",
//					"fb":"07"
//				},
//				"wind":"北风微风",
//				"week":"星期一",
//				"date":"20190114"
//			},
//			"day_20190115":{
//				"temperature":"7℃~12℃",
//				"weather":"小雨",
//				"weather_id":{
//					"fa":"07",
//					"fb":"07"
//				},
//				"wind":"北风3-5级",
//				"week":"星期二",
//				"date":"20190115"
//			},
//			"day_20190116":{
//				"temperature":"10℃~13℃",
//				"weather":"阴转小雨",
//				"weather_id":{
//					"fa":"02",
//					"fb":"07"
//				},
//				"wind":"北风微风",
//				"week":"星期三",
//				"date":"20190116"
//			},
//			"day_20190117":{
//				"temperature":"10℃~13℃",
//				"weather":"阴转小雨",
//				"weather_id":{
//					"fa":"02",
//					"fb":"07"
//				},
//				"wind":"北风微风",
//				"week":"星期四",
//				"date":"20190117"
//			}
//		}
//	},
//	"error_code":0
//}
        [DisplayName("温度")]
        public string Temperature { get; set; }

        [DisplayName("城市")]
        public string City { get; set; }
     

        [DisplayName("风向")]
        public string Wind { get; set; }
        [DisplayName("日期")]
        public string Data { get; set; }
    }
}