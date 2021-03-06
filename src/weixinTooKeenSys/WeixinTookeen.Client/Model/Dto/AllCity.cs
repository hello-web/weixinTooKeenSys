﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeixinTookeen.Client.Model.Dto
{
    public static class AllCity
    {
        public static List<City> allCityData = GetAllCity();
        public static List<City> GetAllCity()
        {
            List<City> city = new List<City>();
            city.Add(new City() { Id = 1, Pid = 0, Name = "北京" });
            AddBJ(city);
            city.Add(new City() { Id = 2, Pid = 0, Name = "天津" });
            AddTJ(city);
            city.Add(new City() { Id = 3, Pid = 0, Name = "河北" });
            AddHEB(city);
            city.Add(new City() { Id = 4, Pid = 0, Name = "山西" });
            AddSX(city);
            city.Add(new City() { Id = 5, Pid = 0, Name = "内蒙古" });
            AddNMG(city);
            city.Add(new City() { Id = 6, Pid = 0, Name = "吉林" });
            AddJL(city);
            city.Add(new City() { Id = 7, Pid = 0, Name = "黑龙江" });
            AddHLJ(city);
            city.Add(new City() { Id = 8, Pid = 0, Name = "上海" });
            AddSH(city);
            city.Add(new City() { Id = 9, Pid = 0, Name = "江苏" });
            AddJS(city);
            city.Add(new City() { Id = 10, Pid = 0, Name = "浙江" });
            AddZHJ(city);
            city.Add(new City() { Id = 11, Pid = 0, Name = "安徽" });
            AddANH(city); 
            city.Add(new City() { Id = 12, Pid = 0, Name = "福建" });
            AddFJ(city);
            city.Add(new City() { Id = 13, Pid = 0, Name = "江西" });
            AddJX(city);
            city.Add(new City() { Id = 14, Pid = 0, Name = "山东" });
            AddSD(city);
            city.Add(new City() { Id = 15, Pid = 0, Name = "河南" });
            AddHN(city);
            city.Add(new City() { Id = 16, Pid = 0, Name = "湖北" });
            AddHUB(city);
            city.Add(new City() { Id = 17, Pid = 0, Name = "湖南" });
            AddHUN(city);
            city.Add(new City() { Id = 18, Pid = 0, Name = "广东" });
            AddGD(city);
            city.Add(new City() { Id = 19, Pid = 0, Name = "广西" });
            AddGX(city);
            city.Add(new City() { Id = 20, Pid = 0, Name = "重庆" });
            AddCQ(city);
            city.Add(new City() { Id = 21, Pid = 0, Name = "海南" });
            AddHaiN(city);
            city.Add(new City() { Id = 22, Pid = 0, Name = "四川" });
            AddSC(city);
            city.Add(new City() { Id = 23, Pid = 0, Name = "贵州" });
            AddGZH(city);
            city.Add(new City() { Id = 24, Pid = 0, Name = "云南" });
            AddYN(city);
            city.Add(new City() { Id = 25, Pid = 0, Name = "西藏" });
            AddXZ(city);
            city.Add(new City() { Id = 26, Pid = 0, Name = "陕西" });
            AddSX(city);
            city.Add(new City() { Id = 27, Pid = 0, Name = "甘肃" });
            AddGS(city);
            city.Add(new City() { Id = 28, Pid = 0, Name = "青海" });
            AddQH(city);
            city.Add(new City() { Id = 29, Pid = 0, Name = "宁夏" });
            AddNX(city);
            city.Add(new City() { Id = 30, Pid = 0, Name = "新疆" });
            AddXJ(city);
            city.Add(new City() { Id = 31, Pid = 0, Name = "台湾" });
            AddTW(city);
            city.Add(new City() { Id = 32, Pid = 0, Name = "香港" });
            AddXG(city);
            city.Add(new City() { Id = 33, Pid = 0, Name = "澳门" });
            AddAOM(city);
            city.Add(new City() { Id = 34, Pid = 0, Name = "辽宁" });
            AddLL(city);
            return city;
        }

        /// <summary>
        ///                 澳门 
        /// </summary>
        /// <param name="city"></param>
        public static void AddAOM(List<City> city)
        {
            city.Add(new City() { Id = 25, Pid = 33, Name = "澳门" });

        }

        /// <summary>
        ///               香港 
        /// </summary>
        /// <param name="city"></param>
        public static void AddXG(List<City> city)
        {
            city.Add(new City() { Id = 35, Pid = 32, Name = "中西"});
            city.Add(new City() { Id = 36, Pid = 32, Name = "湾仔"});
            city.Add(new City() { Id = 37, Pid = 32, Name = "东区" });
            city.Add(new City() { Id = 38, Pid = 32, Name = "南区" });
            city.Add(new City() { Id = 39, Pid = 32, Name = "油尖旺"});
            city.Add(new City() { Id = 40, Pid = 32, Name = "深水埗"});
            city.Add(new City() { Id = 41, Pid = 32, Name = "九龙城"});
            city.Add(new City() { Id = 42, Pid = 32, Name = "黄大仙"});
            city.Add(new City() { Id = 43, Pid = 32, Name = "观塘"});
            city.Add(new City() { Id = 44, Pid = 32, Name = "荃湾"});
            city.Add(new City() { Id = 45, Pid = 32, Name = "葵青"});
            city.Add(new City() { Id = 46, Pid = 32, Name = "沙田"});
            city.Add(new City() { Id = 47, Pid = 32, Name = "西贡"});
            city.Add(new City() { Id = 48, Pid = 32, Name = "大埔"});
            city.Add(new City() { Id = 49, Pid = 32, Name = "北区" });
            city.Add(new City() { Id = 50, Pid = 32, Name = "元朗"});
            city.Add(new City() { Id = 51, Pid = 32, Name = "屯门"});
            city.Add(new City() { Id = 52, Pid = 32, Name = "离岛"});

        }

        /// <summary>
        ///               台湾省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddTW(List<City> city)
        {
            city.Add(new City() { Id = 53, Pid = 31, Name = "台北"});
            city.Add(new City() { Id = 54, Pid = 31, Name = "高雄"});
            city.Add(new City() { Id = 55, Pid = 31, Name = "基隆"});
            city.Add(new City() { Id = 56, Pid = 31, Name = "台中"});
            city.Add(new City() { Id = 57, Pid = 31, Name = "台南"});
            city.Add(new City() { Id = 58, Pid = 31, Name = "新竹"});
            city.Add(new City() { Id = 59, Pid = 31, Name = "嘉义"});
        }

        /// <summary>
        ///             福建省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddFJ(List<City> city)
        {
            city.Add(new City() { Id = 60, Pid = 12, Name = "福州"});
            city.Add(new City() { Id = 61, Pid = 12, Name = "厦门"});
            city.Add(new City() { Id = 62, Pid = 12, Name = "莆田"});
            city.Add(new City() { Id = 63, Pid = 12, Name = "三明"});
            city.Add(new City() { Id = 64, Pid = 12, Name = "泉州"});
            city.Add(new City() { Id = 65, Pid = 12, Name = "漳州"});
            city.Add(new City() { Id = 66, Pid = 12, Name = "南平"});
            city.Add(new City() { Id = 67, Pid = 12, Name = "龙岩"});
            city.Add(new City() { Id = 68, Pid = 12, Name = "宁德"});
        }

        /// <summary>
        ///           浙江省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddZHJ(List<City> city)
        {
            city.Add(new City() { Id = 69, Pid = 10, Name = "杭州"});
            city.Add(new City() { Id = 70, Pid = 10, Name = "宁波"});
            city.Add(new City() { Id = 71, Pid = 10, Name = "温州"});
            city.Add(new City() { Id = 72, Pid = 10, Name = "嘉兴"});
            city.Add(new City() { Id = 73, Pid = 10, Name = "湖州"});
            city.Add(new City() { Id = 74, Pid = 10, Name = "绍兴"});
            city.Add(new City() { Id = 75, Pid = 10, Name = "金华"});
            city.Add(new City() { Id = 76, Pid = 10, Name = "衢州"});
            city.Add(new City() { Id = 77, Pid = 10, Name = "舟山"});
            city.Add(new City() { Id = 78, Pid = 10, Name = "台州"});
            city.Add(new City() { Id = 79, Pid = 10, Name = "丽水"});

        }

        /// <summary>
        ///         安徽省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddANH(List<City> city)
        {
            city.Add(new City() { Id = 80, Pid = 11, Name = "合肥"});
            city.Add(new City() { Id = 81, Pid = 11, Name = "芜湖"});
            city.Add(new City() { Id = 82, Pid = 11, Name = "蚌埠"});
            city.Add(new City() { Id = 83, Pid = 11, Name = "淮南"});
            city.Add(new City() { Id = 84, Pid = 11, Name = "马鞍山"});
            city.Add(new City() { Id = 85, Pid = 11, Name = "淮北"});
            city.Add(new City() { Id = 86, Pid = 11, Name = "铜陵"});
            city.Add(new City() { Id = 87, Pid = 11, Name = "安庆"});
            city.Add(new City() { Id = 88, Pid = 11, Name = "黄山"});
            city.Add(new City() { Id = 89, Pid = 11, Name = "滁州"});
            city.Add(new City() { Id = 90, Pid = 11, Name = "阜阳"});
            city.Add(new City() { Id = 91, Pid = 11, Name = "宿州"});
            city.Add(new City() { Id = 92, Pid = 11, Name = "巢湖"});
            city.Add(new City() { Id = 93, Pid = 11, Name = "六安"});
            city.Add(new City() { Id = 94, Pid = 11, Name = "亳州"});
            city.Add(new City() { Id = 95, Pid = 11, Name = "池州"});
            city.Add(new City() { Id = 96, Pid = 11, Name = "宣城"});

        }

        /// <summary>
        ///       新疆自治区 
        /// </summary>
        /// <param name="city"></param>
        public static void AddXJ(List<City> city)
        {
            city.Add(new City() { Id = 97, Pid = 30, Name = "乌鲁木齐"});
            city.Add(new City() { Id = 98, Pid = 30, Name = "克拉玛依"});
            city.Add(new City() { Id = 99, Pid = 30, Name = "吐鲁番地"});
            city.Add(new City() { Id = 100, Pid = 30, Name = "哈密地"});
            city.Add(new City() { Id = 101, Pid = 30, Name = "昌吉" });
            city.Add(new City() { Id = 102, Pid = 30, Name = "博尔塔拉" });
            city.Add(new City() { Id = 103, Pid = 30, Name = "巴音郭楞" });
            city.Add(new City() { Id = 104, Pid = 30, Name = "阿克苏地"});
            city.Add(new City() { Id = 105, Pid = 30, Name = "克孜勒苏柯尔克孜" });
            city.Add(new City() { Id = 106, Pid = 30, Name = "喀什地"});
            city.Add(new City() { Id = 107, Pid = 30, Name = "和田地"});
            city.Add(new City() { Id = 108, Pid = 30, Name = "伊犁哈萨克" });
            city.Add(new City() { Id = 109, Pid = 30, Name = "塔城地"});
            city.Add(new City() { Id = 110, Pid = 30, Name = "阿勒泰地"});
            city.Add(new City() { Id = 111, Pid = 30, Name = "石河子"});
            city.Add(new City() { Id = 112, Pid = 30, Name = "阿拉尔"});
            city.Add(new City() { Id = 113, Pid = 30, Name = "图木舒克"});
            city.Add(new City() { Id = 114, Pid = 30, Name = "五家渠"});

        }
        /// <summary>
        ///       西藏自治区 
        /// </summary>
        /// <param name="city"></param>
        public static void AddXZ(List<City> city)
        {
            city.Add(new City() { Id = 115, Pid = 25, Name = "拉萨"});
            city.Add(new City() { Id = 116, Pid = 25, Name = "昌都"});
            city.Add(new City() { Id = 117, Pid = 25, Name = "山南"});
            city.Add(new City() { Id = 118, Pid = 25, Name = "日喀则"});
            city.Add(new City() { Id = 119, Pid = 25, Name = "那曲"});
            city.Add(new City() { Id = 120, Pid = 25, Name = "阿里"});
            city.Add(new City() { Id = 121, Pid = 25, Name = "林芝"});

        }
        /// <summary>
        ///           青海省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddQH(List<City> city)
        {
            city.Add(new City() { Id = 122, Pid = 28, Name = "西宁"});
            city.Add(new City() { Id = 123, Pid = 28, Name = "海东"});
            city.Add(new City() { Id = 124, Pid = 28, Name = "海北" });
            city.Add(new City() { Id = 125, Pid = 28, Name = "黄南" });
            city.Add(new City() { Id = 126, Pid = 28, Name = "海南" });
            city.Add(new City() { Id = 127, Pid = 28, Name = "果洛" });
            city.Add(new City() { Id = 128, Pid = 28, Name = "玉树" });
            city.Add(new City() { Id = 129, Pid = 28, Name = "海西" });

        }
        /// <summary>
        ///       甘肃省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddGS(List<City> city)
        {
            city.Add(new City() { Id = 130, Pid = 27, Name = "兰州"});
            city.Add(new City() { Id = 131, Pid = 27, Name = "嘉峪关"});
            city.Add(new City() { Id = 134, Pid = 27, Name = "金昌"});
            city.Add(new City() { Id = 135, Pid = 27, Name = "白银"});
            city.Add(new City() { Id = 136, Pid = 27, Name = "天水"});
            city.Add(new City() { Id = 137, Pid = 27, Name = "武威"});
            city.Add(new City() { Id = 138, Pid = 27, Name = "张掖"});
            city.Add(new City() { Id = 139, Pid = 27, Name = "平凉"});
            city.Add(new City() { Id = 140, Pid = 27, Name = "酒泉"});
            city.Add(new City() { Id = 140, Pid = 27, Name = "庆阳"});
            city.Add(new City() { Id = 142, Pid = 27, Name = "定西"});
            city.Add(new City() { Id = 143, Pid = 27, Name = "陇南"});
            city.Add(new City() { Id = 144, Pid = 27, Name = "临夏" });
            city.Add(new City() { Id = 145, Pid = 27, Name = "甘南" });
        }
        /// <summary>
        ///      宁夏回族自治区 
        /// </summary>
        /// <param name="city"></param>
        public static void AddNX(List<City> city)
        {
            city.Add(new City() { Id = 146, Pid = 29, Name = "银川"});
            city.Add(new City() { Id = 147, Pid = 29, Name = "石嘴山"});
            city.Add(new City() { Id = 148, Pid = 29, Name = "吴忠"});
            city.Add(new City() { Id = 149, Pid = 29, Name = "固原"});
            city.Add(new City() { Id = 150, Pid = 29, Name = "中卫"});
        }
        /// <summary>
        ///       内蒙古自治区 
        /// </summary>
        /// <param name="city"></param>
        public static void AddNMG(List<City> city)
        {
            city.Add(new City() { Id = 151, Pid = 5, Name = "呼和浩特"});
            city.Add(new City() { Id = 152, Pid = 5, Name = "包头"});
            city.Add(new City() { Id = 153, Pid = 5, Name = "乌海"});
            city.Add(new City() { Id = 154, Pid = 5, Name = "赤峰"});
            city.Add(new City() { Id = 155, Pid = 5, Name = "通辽"});
            city.Add(new City() { Id = 156, Pid = 5, Name = "鄂尔多斯"});
            city.Add(new City() { Id = 157, Pid = 5, Name = "呼伦贝尔"});
            city.Add(new City() { Id = 158, Pid = 5, Name = "巴彦淖尔"});
            city.Add(new City() { Id = 159, Pid = 5, Name = "乌兰察布"});
            city.Add(new City() { Id = 160, Pid = 5, Name = "兴安盟" });
            city.Add(new City() { Id = 161, Pid = 5, Name = "锡林郭勒盟" });
            city.Add(new City() { Id = 162, Pid = 5, Name = "阿拉善盟" });
        }
        /// <summary>
        ///       四川省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddSC(List<City> city)
        {
            city.Add(new City() { Id = 163, Pid = 22, Name = "成都"});
            city.Add(new City() { Id = 164, Pid = 22, Name = "自贡"});
            city.Add(new City() { Id = 165, Pid = 22, Name = "攀枝花"});
            city.Add(new City() { Id = 166, Pid = 22, Name = "泸州"});
            city.Add(new City() { Id = 167, Pid = 22, Name = "德阳"});
            city.Add(new City() { Id = 168, Pid = 22, Name = "绵阳"});
            city.Add(new City() { Id = 169, Pid = 22, Name = "广元"});
            city.Add(new City() { Id = 170, Pid = 22, Name = "遂宁"});
            city.Add(new City() { Id = 171, Pid = 22, Name = "内江"});
            city.Add(new City() { Id = 172, Pid = 22, Name = "乐山"});
            city.Add(new City() { Id = 173, Pid = 22, Name = "南充"});
            city.Add(new City() { Id = 174, Pid = 22, Name = "眉山"});
            city.Add(new City() { Id = 175, Pid = 22, Name = "宜宾"});
            city.Add(new City() { Id = 176, Pid = 22, Name = "广安"});
            city.Add(new City() { Id = 177, Pid = 22, Name = "达州"});
            city.Add(new City() { Id = 178, Pid = 22, Name = "雅安"});
            city.Add(new City() { Id = 179, Pid = 22, Name = "巴中"});
            city.Add(new City() { Id = 180, Pid = 22, Name = "资阳"});
            city.Add(new City() { Id = 181, Pid = 22, Name = "阿坝" });
            city.Add(new City() { Id = 182, Pid = 22, Name = "甘孜" });
        }
        /// <summary>
        ///       贵州省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddGZH(List<City> city)
        {
            city.Add(new City() { Id = 183, Pid = 23, Name = "贵阳"});
            city.Add(new City() { Id = 184, Pid = 23, Name = "六盘水"});
            city.Add(new City() { Id = 185, Pid = 23, Name = "遵义"});
            city.Add(new City() { Id = 186, Pid = 23, Name = "安顺"});
            city.Add(new City() { Id = 187, Pid = 23, Name = "铜仁"});
            city.Add(new City() { Id = 188, Pid = 23, Name = "黔西南" });
            city.Add(new City() { Id = 189, Pid = 23, Name = "毕节"});
            city.Add(new City() { Id = 190, Pid = 23, Name = "黔东南" });
            city.Add(new City() { Id = 191, Pid = 23, Name = "黔南" });
        }

        /// <summary>
        ///       云南省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddYN(List<City> city)
        {
            city.Add(new City() { Id = 192, Pid = 24, Name = "昆明"});
            city.Add(new City() { Id = 193, Pid = 24, Name = "曲靖"});
            city.Add(new City() { Id = 194, Pid = 24, Name = "玉溪"});
            city.Add(new City() { Id = 195, Pid = 24, Name = "保山"});
            city.Add(new City() { Id = 196, Pid = 24, Name = "昭通"});
            city.Add(new City() { Id = 197, Pid = 24, Name = "丽江"});
            city.Add(new City() { Id = 198, Pid = 24, Name = "思茅"});
            city.Add(new City() { Id = 199, Pid = 24, Name = "临沧"});
            city.Add(new City() { Id = 200, Pid = 24, Name = "楚雄" });
            city.Add(new City() { Id = 201, Pid = 24, Name = "红河" });
            city.Add(new City() { Id = 202, Pid = 24, Name = "文山" });
            city.Add(new City() { Id = 203, Pid = 24, Name = "西双版纳" });
            city.Add(new City() { Id = 204, Pid = 24, Name = "大理" });
            city.Add(new City() { Id = 205, Pid = 24, Name = "德宏" });
            city.Add(new City() { Id = 206, Pid = 24, Name = "怒江" });
            city.Add(new City() { Id = 207, Pid = 24, Name = "迪庆" });
                                       
        }

        /// <summary>
        ///     广西省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddGX(List<City> city)
        {
            city.Add(new City() { Id = 208, Pid = 19, Name = "南宁"});
            city.Add(new City() { Id = 209, Pid = 19, Name = "柳州"});
            city.Add(new City() { Id = 210, Pid = 19, Name = "桂林"});
            city.Add(new City() { Id = 211, Pid = 19, Name = "梧州"});
            city.Add(new City() { Id = 212, Pid = 19, Name = "北海"});
            city.Add(new City() { Id = 213, Pid = 19, Name = "防城港" });
            city.Add(new City() { Id = 214, Pid = 19, Name = "钦州"});
            city.Add(new City() { Id = 215, Pid = 19, Name = "贵港"});
            city.Add(new City() { Id = 216, Pid = 19, Name = "玉林"});
            city.Add(new City() { Id = 217, Pid = 19, Name = "百色"});
            city.Add(new City() { Id = 218, Pid = 19, Name = "贺州"});
            city.Add(new City() { Id = 219, Pid = 19, Name = "河池"});
            city.Add(new City() { Id = 220, Pid = 19, Name = "来宾"});
            city.Add(new City() { Id = 221, Pid = 19, Name = "崇左"});
        }

        /// <summary>
        ///     广东省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddGD(List<City> city)
        {
            city.Add(new City() { Id = 222, Pid = 18, Name = "广州"});
            city.Add(new City() { Id = 223, Pid = 18, Name = "韶关"});
            city.Add(new City() { Id = 224, Pid = 18, Name = "深圳"});
            city.Add(new City() { Id = 225, Pid = 18, Name = "珠海"});
            city.Add(new City() { Id = 226, Pid = 18, Name = "汕头"});
            city.Add(new City() { Id = 227, Pid = 18, Name = "佛山"});
            city.Add(new City() { Id = 228, Pid = 18, Name = "江门"});
            city.Add(new City() { Id = 229, Pid = 18, Name = "湛江"});
            city.Add(new City() { Id = 230, Pid = 18, Name = "茂名"});
            city.Add(new City() { Id = 231, Pid = 18, Name = "肇庆"});
            city.Add(new City() { Id = 234, Pid = 18, Name = "惠州"});
            city.Add(new City() { Id = 235, Pid = 18, Name = "梅州"});
            city.Add(new City() { Id = 236, Pid = 18, Name = "汕尾"});
            city.Add(new City() { Id = 237, Pid = 18, Name = "河源"});
            city.Add(new City() { Id = 238, Pid = 18, Name = "阳江"});
            city.Add(new City() { Id = 239, Pid = 18, Name = "清远"});
            city.Add(new City() { Id = 240, Pid = 18, Name = "东莞"});
            city.Add(new City() { Id = 240, Pid = 18, Name = "中山"});
            city.Add(new City() { Id = 242, Pid = 18, Name = "潮州"});
            city.Add(new City() { Id = 243, Pid = 18, Name = "揭阳"});
            city.Add(new City() { Id = 244, Pid = 18, Name = "云浮"});

        }
        /// <summary>
        ///    江西省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddJX(List<City> city)
        {
            city.Add(new City() { Id = 245, Pid = 13, Name = "南昌"});
            city.Add(new City() { Id = 246, Pid = 13, Name = "景德镇"});
            city.Add(new City() { Id = 247, Pid = 13, Name = "萍乡"});
            city.Add(new City() { Id = 248, Pid = 13, Name = "九江"});
            city.Add(new City() { Id = 249, Pid = 13, Name = "新余"});
            city.Add(new City() { Id = 250, Pid = 13, Name = "鹰潭"});
            city.Add(new City() { Id = 251, Pid = 13, Name = "赣州"});
            city.Add(new City() { Id = 252, Pid = 13, Name = "吉安"});
            city.Add(new City() { Id = 253, Pid = 13, Name = "宜春"});
            city.Add(new City() { Id = 254, Pid = 13, Name = "抚州"});
                                       
        }


        /// <summary>
        ///                   江苏省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddJS(List<City> city)
        {
            city.Add(new City() { Id = 255, Pid = 9, Name = "南京"});
            city.Add(new City() { Id = 256, Pid = 9, Name = "无锡"});
            city.Add(new City() { Id = 257, Pid = 9, Name = "徐州"});
            city.Add(new City() { Id = 258, Pid = 9, Name = "常州"});
            city.Add(new City() { Id = 259, Pid = 9, Name = "苏州"});
            city.Add(new City() { Id = 260, Pid = 9, Name = "南通"});
            city.Add(new City() { Id = 261, Pid = 9, Name = "连云港"});
            city.Add(new City() { Id = 262, Pid = 9, Name = "淮安"});
            city.Add(new City() { Id = 263, Pid = 9, Name = "盐城"});
            city.Add(new City() { Id = 264, Pid = 9, Name = "扬州"});
            city.Add(new City() { Id = 265, Pid = 9, Name = "镇江"});
            city.Add(new City() { Id = 266, Pid = 9, Name = "泰州"});
            city.Add(new City() { Id = 267, Pid = 9, Name = "宿迁"});

        }


        /// <summary>
        ///                 海南省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddHaiN(List<City> city)
        {
            city.Add(new City() { Id = 268, Pid = 21, Name = "海口"});
            city.Add(new City() { Id = 269, Pid = 21, Name = "三亚"});
            city.Add(new City() { Id = 270, Pid = 21, Name = "五指山"});
            city.Add(new City() { Id = 271, Pid = 21, Name = "琼海"});
            city.Add(new City() { Id = 272, Pid = 21, Name = "儋州"});
            city.Add(new City() { Id = 273, Pid = 21, Name = "文昌"});
            city.Add(new City() { Id = 274, Pid = 21, Name = "万宁"});
            city.Add(new City() { Id = 275, Pid = 21, Name = "东方"});
            city.Add(new City() { Id = 276, Pid = 21, Name = "定安县" });
            city.Add(new City() { Id = 277, Pid = 21, Name = "屯昌县" });
            city.Add(new City() { Id = 278, Pid = 21, Name = "澄迈县" });
            city.Add(new City() { Id = 279, Pid = 21, Name = "临高县" });
            city.Add(new City() { Id = 280, Pid = 21, Name = "白沙黎族自治县" });
            city.Add(new City() { Id = 281, Pid = 21, Name = "昌江黎族自治县" });
            city.Add(new City() { Id = 282, Pid = 21, Name = "乐东黎族自治县" });
            city.Add(new City() { Id = 283, Pid = 21, Name = "陵水黎族自治县" });
            city.Add(new City() { Id = 284, Pid = 21, Name = "保亭黎族苗族自治县" });
            city.Add(new City() { Id = 285, Pid = 21, Name = "琼中黎族苗族自治县" });

        }


        /// <summary>
        ///               湖南省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddHUN(List<City> city)
        {
            city.Add(new City() { Id = 286, Pid = 17, Name = "长沙"});
            city.Add(new City() { Id = 287, Pid = 17, Name = "株洲"});
            city.Add(new City() { Id = 288, Pid = 17, Name = "湘潭"});
            city.Add(new City() { Id = 289, Pid = 17, Name = "衡阳"});
            city.Add(new City() { Id = 290, Pid = 17, Name = "邵阳"});
            city.Add(new City() { Id = 291, Pid = 17, Name = "岳阳"});
            city.Add(new City() { Id = 292, Pid = 17, Name = "常德"});
            city.Add(new City() { Id = 293, Pid = 17, Name = "张家界"});
            city.Add(new City() { Id = 294, Pid = 17, Name = "益阳"});
            city.Add(new City() { Id = 295, Pid = 17, Name = "郴州"});
            city.Add(new City() { Id = 296, Pid = 17, Name = "永州"});
            city.Add(new City() { Id = 297, Pid = 17, Name = "怀化"});
            city.Add(new City() { Id = 298, Pid = 17, Name = "娄底"});
            city.Add(new City() { Id = 299, Pid = 17, Name = "湘西" });
                                       
        }                              


        /// <summary>
        ///             湖北省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddHUB(List<City> city)
        {
            city.Add(new City() { Id = 300, Pid = 16, Name = "武汉"});
            city.Add(new City() { Id = 301, Pid = 16, Name = "黄石"});
            city.Add(new City() { Id = 302, Pid = 16, Name = "十堰"});
            city.Add(new City() { Id = 303, Pid = 16, Name = "宜昌"});
            city.Add(new City() { Id = 304, Pid = 16, Name = "襄樊"});
            city.Add(new City() { Id = 305, Pid = 16, Name = "鄂州"});
            city.Add(new City() { Id = 306, Pid = 16, Name = "荆门"});
            city.Add(new City() { Id = 307, Pid = 16, Name = "孝感"});
            city.Add(new City() { Id = 308, Pid = 16, Name = "荆州"});
            city.Add(new City() { Id = 309, Pid = 16, Name = "黄冈"});
            city.Add(new City() { Id = 310, Pid = 16, Name = "咸宁"});
            city.Add(new City() { Id = 311, Pid = 16, Name = "随州"});
            city.Add(new City() { Id = 312, Pid = 16, Name = "恩施" });
            city.Add(new City() { Id = 313, Pid = 16, Name = "仙桃"});
            city.Add(new City() { Id = 314, Pid = 16, Name = "潜江"});
            city.Add(new City() { Id = 315, Pid = 16, Name = "天门"});
            city.Add(new City() { Id = 316, Pid = 16, Name = "神农架林"});

        }

        /// <summary>
        ///           河南省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddHN(List<City> city)
        {
            city.Add(new City() { Id = 317, Pid = 15, Name = "郑州"});
            city.Add(new City() { Id = 318, Pid = 15, Name = "开封"});
            city.Add(new City() { Id = 319, Pid = 15, Name = "洛阳"});
            city.Add(new City() { Id = 320, Pid = 15, Name = "平顶山"});
            city.Add(new City() { Id = 321, Pid = 15, Name = "安阳"});
            city.Add(new City() { Id = 322, Pid = 15, Name = "鹤壁"});
            city.Add(new City() { Id = 323, Pid = 15, Name = "新乡"});
            city.Add(new City() { Id = 324, Pid = 15, Name = "焦作"});
            city.Add(new City() { Id = 325, Pid = 15, Name = "济源"});
            city.Add(new City() { Id = 326, Pid = 15, Name = "濮阳"});
            city.Add(new City() { Id = 327, Pid = 15, Name = "许昌"});
            city.Add(new City() { Id = 328, Pid = 15, Name = "漯河"});
            city.Add(new City() { Id = 329, Pid = 15, Name = "三门峡"});
            city.Add(new City() { Id = 330, Pid = 15, Name = "南阳"});
            city.Add(new City() { Id = 331, Pid = 15, Name = "商丘"});
            city.Add(new City() { Id = 334, Pid = 15, Name = "信阳"});
            city.Add(new City() { Id = 335, Pid = 15, Name = "周口"});
            city.Add(new City() { Id = 336, Pid = 15, Name = "驻马店"});
                                       
        }                              
                                       
        /// <summary>
        ///         河北省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddHEB(List<City> city)
        {
            city.Add(new City() { Id = 337, Pid = 3, Name = "石家庄"});
            city.Add(new City() { Id = 338, Pid = 3, Name = "唐山"});
            city.Add(new City() { Id = 339, Pid = 3, Name = "秦皇岛"});
            city.Add(new City() { Id = 340, Pid = 3, Name = "邯郸"});
            city.Add(new City() { Id = 340, Pid = 3, Name = "邢台"});
            city.Add(new City() { Id = 342, Pid = 3, Name = "保定"});
            city.Add(new City() { Id = 343, Pid = 3, Name = "张家口"});
            city.Add(new City() { Id = 344, Pid = 3, Name = "承德"});
            city.Add(new City() { Id = 345, Pid = 3, Name = "沧州"});
            city.Add(new City() { Id = 346, Pid = 3, Name = "廊坊"});
            city.Add(new City() { Id = 347, Pid = 3, Name = "衡水"});
        }

        /// <summary>
        ///       陕西省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddSHX(List<City> city)
        {
            city.Add(new City() { Id = 348, Pid = 26, Name = "西安"});
            city.Add(new City() { Id = 349, Pid = 26, Name = "铜川"});
            city.Add(new City() { Id = 350, Pid = 26, Name = "宝鸡"});
            city.Add(new City() { Id = 351, Pid = 26, Name = "咸阳"});
            city.Add(new City() { Id = 352, Pid = 26, Name = "渭南"});
            city.Add(new City() { Id = 353, Pid = 26, Name = "延安"});
            city.Add(new City() { Id = 354, Pid = 26, Name = "汉中"});
            city.Add(new City() { Id = 355, Pid = 26, Name = "榆林"});
            city.Add(new City() { Id = 356, Pid = 26, Name = "安康"});
            city.Add(new City() { Id = 357, Pid = 26, Name = "商洛"});
        }                                


        /// <summary>
        ///     山西省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddSX(List<City> city)
        {
            city.Add(new City() { Id = 358, Pid = 4, Name = "太原"});
            city.Add(new City() { Id = 359, Pid = 4, Name = "大同"});
            city.Add(new City() { Id = 360, Pid = 4, Name = "阳泉"});
            city.Add(new City() { Id = 361, Pid = 4, Name = "长治"});
            city.Add(new City() { Id = 362, Pid = 4, Name = "晋城"});
            city.Add(new City() { Id = 363, Pid = 4, Name = "朔州"});
            city.Add(new City() { Id = 364, Pid = 4, Name = "晋中"});
            city.Add(new City() { Id = 365, Pid = 4, Name = "运城"});
            city.Add(new City() { Id = 366, Pid = 4, Name = "忻州"});
            city.Add(new City() { Id = 367, Pid = 4, Name = "临汾"});
            city.Add(new City() { Id = 368, Pid = 4, Name = "吕梁"});
        }                               
                                        
        /// <summary>
        ///   山东省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddSD(List<City> city)
        {
            city.Add(new City() { Id = 369, Pid = 14, Name = "济南"});
            city.Add(new City() { Id = 370, Pid = 14, Name = "青岛"});
            city.Add(new City() { Id = 371, Pid = 14, Name = "淄博"});
            city.Add(new City() { Id = 372, Pid = 14, Name = "枣庄"});
            city.Add(new City() { Id = 373, Pid = 14, Name = "东营"});
            city.Add(new City() { Id = 374, Pid = 14, Name = "烟台"});
            city.Add(new City() { Id = 375, Pid = 14, Name = "潍坊"});
            city.Add(new City() { Id = 376, Pid = 14, Name = "济宁"});
            city.Add(new City() { Id = 377, Pid = 14, Name = "泰安"});
            city.Add(new City() { Id = 378, Pid = 14, Name = "威海"});
            city.Add(new City() { Id = 379, Pid = 14, Name = "日照"});
            city.Add(new City() { Id = 380, Pid = 14, Name = "莱芜"});
            city.Add(new City() { Id = 381, Pid = 14, Name = "临沂"});
            city.Add(new City() { Id = 382, Pid = 14, Name = "德州"});
            city.Add(new City() { Id = 383, Pid = 14, Name = "聊城"});
            city.Add(new City() { Id = 384, Pid = 14, Name = "滨州"});
            city.Add(new City() { Id = 385, Pid = 14, Name = "菏泽"});

        }


        /// <summary>
        ///   辽宁省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddLL(List<City> city)
        {
            city.Add(new City() { Id = 386, Pid = 34, Name = "沈阳"});
            city.Add(new City() { Id = 387, Pid = 34, Name = "大连"});
            city.Add(new City() { Id = 388, Pid = 34, Name = "鞍山"});
            city.Add(new City() { Id = 389, Pid = 34, Name = "抚顺"});
            city.Add(new City() { Id = 390, Pid = 34, Name = "本溪"});
            city.Add(new City() { Id = 391, Pid = 34, Name = "丹东"});
            city.Add(new City() { Id = 392, Pid = 34, Name = "锦州"});
            city.Add(new City() { Id = 393, Pid = 34, Name = "营口"});
            city.Add(new City() { Id = 394, Pid = 34, Name = "阜新"});
            city.Add(new City() { Id = 395, Pid = 34, Name = "辽阳"});
            city.Add(new City() { Id = 396, Pid = 34, Name = "盘锦"});
            city.Add(new City() { Id = 397, Pid = 34, Name = "铁岭"});
            city.Add(new City() { Id = 398, Pid = 34, Name = "朝阳"});
            city.Add(new City() { Id = 399, Pid = 34, Name = "葫芦岛"});
                                        
        }                               

        /// <summary>
        ///   吉林省
        /// </summary>
        /// <param name="city"></param>
        public static void AddJL(List<City> city)
        {
            city.Add(new City() { Id = 400, Pid = 6, Name = "长春"});
            city.Add(new City() { Id = 401, Pid = 6, Name = "吉林"});
            city.Add(new City() { Id = 402, Pid = 6, Name = "四平"});
            city.Add(new City() { Id = 403, Pid = 6, Name = "辽源"});
            city.Add(new City() { Id = 404, Pid = 6, Name = "通化"});
            city.Add(new City() { Id = 405, Pid = 6, Name = "白山"});
            city.Add(new City() { Id = 406, Pid = 6, Name = "松原"});
            city.Add(new City() { Id = 407, Pid = 6, Name = "白城"});
            city.Add(new City() { Id = 408, Pid = 6, Name = "延边" });

        }
        /// <summary>
        ///   黑龙江省 
        /// </summary>
        /// <param name="city"></param>
        public static void AddHLJ(List<City> city)
        {
            city.Add(new City() { Id = 409, Pid = 7, Name = "哈尔滨"});
            city.Add(new City() { Id = 410, Pid = 7, Name = "齐齐哈尔"});
            city.Add(new City() { Id = 411, Pid = 7, Name = "鸡西"});
            city.Add(new City() { Id = 412, Pid = 7, Name = "鹤岗"});
            city.Add(new City() { Id = 413, Pid = 7, Name = "双鸭山"});
            city.Add(new City() { Id = 414, Pid = 7, Name = "大庆"});
            city.Add(new City() { Id = 415, Pid = 7, Name = "伊春"});
            city.Add(new City() { Id = 416, Pid = 7, Name = "佳木斯"});
            city.Add(new City() { Id = 417, Pid = 7, Name = "七台河"});
            city.Add(new City() { Id = 418, Pid = 7, Name = "牡丹江"});
            city.Add(new City() { Id = 419, Pid = 7, Name = "黑河"});
            city.Add(new City() { Id = 420, Pid = 7, Name = "绥化"});
            city.Add(new City() { Id = 421, Pid = 7, Name = "大兴安岭"});
        }

        /// <summary>
        /// 重庆
        /// </summary>
        /// <param name="city"></param>
        public static void AddCQ(List<City> city)
        {
            city.Add(new City() { Id = 422, Pid = 20, Name = "万州"});
            city.Add(new City() { Id = 423, Pid = 20, Name = "涪陵"});
            city.Add(new City() { Id = 424, Pid = 20, Name = "渝中"});
            city.Add(new City() { Id = 425, Pid = 20, Name = "大渡口"});
            city.Add(new City() { Id = 426, Pid = 20, Name = "江北"});
            city.Add(new City() { Id = 427, Pid = 20, Name = "沙坪坝"});
            city.Add(new City() { Id = 428, Pid = 20, Name = "九龙坡"});
            city.Add(new City() { Id = 429, Pid = 20, Name = "南岸"});
            city.Add(new City() { Id = 430, Pid = 20, Name = "北碚"});
            city.Add(new City() { Id = 431, Pid = 20, Name = "万盛"});
            city.Add(new City() { Id = 434, Pid = 20, Name = "双桥"});
            city.Add(new City() { Id = 435, Pid = 20, Name = "渝北"});
            city.Add(new City() { Id = 436, Pid = 20, Name = "巴南"});
            city.Add(new City() { Id = 437, Pid = 20, Name = "黔江"});
            city.Add(new City() { Id = 438, Pid = 20, Name = "长寿"});
            city.Add(new City() { Id = 439, Pid = 20, Name = "江津"});
            city.Add(new City() { Id = 440, Pid = 20, Name = "合川"});
            city.Add(new City() { Id = 440, Pid = 20, Name = "永川"});
            city.Add(new City() { Id = 442, Pid = 20, Name = "南川"});
            city.Add(new City() { Id = 443, Pid = 20, Name = "綦江县" });
            city.Add(new City() { Id = 444, Pid = 20, Name = "潼南县" });
            city.Add(new City() { Id = 445, Pid = 20, Name = "铜梁县" });
            city.Add(new City() { Id = 446, Pid = 20, Name = "大足县" });
            city.Add(new City() { Id = 447, Pid = 20, Name = "荣昌县" });
            city.Add(new City() { Id = 448, Pid = 20, Name = "璧山县" });
            city.Add(new City() { Id = 449, Pid = 20, Name = "梁平县" });
            city.Add(new City() { Id = 450, Pid = 20, Name = "城口县" });
            city.Add(new City() { Id = 451, Pid = 20, Name = "丰都县" });
            city.Add(new City() { Id = 452, Pid = 20, Name = "垫江县" });
            city.Add(new City() { Id = 453, Pid = 20, Name = "武隆县" });
            city.Add(new City() { Id = 454, Pid = 20, Name = "忠县" });
            city.Add(new City() { Id = 455, Pid = 20, Name = "开县" });
            city.Add(new City() { Id = 456, Pid = 20, Name = "云阳县" });
            city.Add(new City() { Id = 457, Pid = 20, Name = "奉节县" });
            city.Add(new City() { Id = 458, Pid = 20, Name = "巫山县" });
            city.Add(new City() { Id = 459, Pid = 20, Name = "巫溪县" });
            city.Add(new City() { Id = 460, Pid = 20, Name = "石柱土家族自治县" });
            city.Add(new City() { Id = 461, Pid = 20, Name = "秀山土家族苗族自治县" });
            city.Add(new City() { Id = 462, Pid = 20, Name = "酉阳土家族苗族自治县" });
            city.Add(new City() { Id = 463, Pid = 20, Name = "彭水苗族土家族自治县" });
                                       
        }                              
                                       
        /// <summary>
        /// 北京
        /// </summary>
        /// <param name="city"></param>
        public static void AddBJ(List<City> city)
        {
            city.Add(new City() { Id = 464, Pid = 1, Name = "东城"});
            city.Add(new City() { Id = 465, Pid = 1, Name = "西城"});
            city.Add(new City() { Id = 466, Pid = 1, Name = "朝阳"});
            city.Add(new City() { Id = 467, Pid = 1, Name = "丰台"});
            city.Add(new City() { Id = 468, Pid = 1, Name = "石景山"});
            city.Add(new City() { Id = 469, Pid = 1, Name = "海淀"});
            city.Add(new City() { Id = 470, Pid = 1, Name = "门头沟"});
            city.Add(new City() { Id = 471, Pid = 1, Name = "房山"});
            city.Add(new City() { Id = 472, Pid = 1, Name = "通州"});
            city.Add(new City() { Id = 473, Pid = 1, Name = "顺义"});
            city.Add(new City() { Id = 474, Pid = 1, Name = "昌平"});
            city.Add(new City() { Id = 475, Pid = 1, Name = "大兴"});
            city.Add(new City() { Id = 476, Pid = 1, Name = "怀柔"});
            city.Add(new City() { Id = 477, Pid = 1, Name = "平谷"});
            city.Add(new City() { Id = 478, Pid = 1, Name = "密云"});
            city.Add(new City() { Id = 479, Pid = 1, Name = "延庆"});
        }                              
                                       
        /// <summary>                  
        /// 上海                        
        /// </summary>
        /// <param name="city"></param>
        public static void AddSH(List<City> city)
        {
            city.Add(new City() { Id = 480, Pid = 8, Name = "黄浦"});
            city.Add(new City() { Id = 481, Pid = 8, Name = "卢湾"});
            city.Add(new City() { Id = 482, Pid = 8, Name = "徐汇"});
            city.Add(new City() { Id = 483, Pid = 8, Name = "长宁"});
            city.Add(new City() { Id = 484, Pid = 8, Name = "静安"});
            city.Add(new City() { Id = 485, Pid = 8, Name = "普陀"});
            city.Add(new City() { Id = 486, Pid = 8, Name = "闸北"});
            city.Add(new City() { Id = 487, Pid = 8, Name = "虹口"});
            city.Add(new City() { Id = 488, Pid = 8, Name = "杨浦"});
            city.Add(new City() { Id = 489, Pid = 8, Name = "闵行"});
            city.Add(new City() { Id = 490, Pid = 8, Name = "宝山"});
            city.Add(new City() { Id = 491, Pid = 8, Name = "嘉定"});
            city.Add(new City() { Id = 492, Pid = 8, Name = "浦东新"});
            city.Add(new City() { Id = 493, Pid = 8, Name = "金山"});
            city.Add(new City() { Id = 494, Pid = 8, Name = "松江"});
            city.Add(new City() { Id = 495, Pid = 8, Name = "青浦"});
            city.Add(new City() { Id = 496, Pid = 8, Name = "南汇"});
            city.Add(new City() { Id = 497, Pid = 8, Name = "奉贤"});
            city.Add(new City() { Id = 498, Pid = 8, Name = "崇明县" });
        }

        /// <summary>
        /// 天津
        /// </summary>
        /// <param name="city"></param>
        public static void AddTJ(List<City> city)
        {
            city.Add(new City() { Id = 499, Pid = 2, Name = "和平"});
            city.Add(new City() { Id = 500, Pid = 2, Name = "河东"});
            city.Add(new City() { Id = 501, Pid = 2, Name = "河西"});
            city.Add(new City() { Id = 502, Pid = 2, Name = "南开"});
            city.Add(new City() { Id = 503, Pid = 2, Name = "河北"});
            city.Add(new City() { Id = 504, Pid = 2, Name = "红桥"});
            city.Add(new City() { Id = 505, Pid = 2, Name = "塘沽"});
            city.Add(new City() { Id = 506, Pid = 2, Name = "汉沽"});
            city.Add(new City() { Id = 507, Pid = 2, Name = "大港"});
            city.Add(new City() { Id = 508, Pid = 2, Name = "东丽"});
            city.Add(new City() { Id = 509, Pid = 2, Name = "西青"});
            city.Add(new City() { Id = 510, Pid = 2, Name = "津南"});
            city.Add(new City() { Id = 511, Pid = 2, Name = "北辰"});
            city.Add(new City() { Id = 512, Pid = 2, Name = "武清"});
            city.Add(new City() { Id = 513, Pid = 2, Name = "宝坻"});
            city.Add(new City() { Id = 514, Pid = 2, Name = "宁河县" });
            city.Add(new City() { Id = 515, Pid = 2, Name = " 静海县" });
            city.Add(new City() { Id = 516, Pid = 2, Name = " 蓟县" });

        }
    }
}
