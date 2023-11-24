using System.Collections.Generic;

namespace POELiveSplitComponent.Component.Timer
{
    public class Zone : IZone
    {
        public enum IconType { Wp, NoWp, Town }

        public static readonly List<Zone> ZONES;

        private static readonly Dictionary<Zone, Zone> REQUIRED;

        public static readonly Dictionary<IZone, IconType> ICONTYPES;

        static Zone()
        {
            ZONES = new List<Zone>();
            REQUIRED = new Dictionary<Zone, Zone>();
            ICONTYPES = new Dictionary<IZone, IconType>();

            Zone kitavaPart1Kill = new Zone("教堂顶楼", 1);
            Zone act6Home = new Zone("狮眼守望", 2);
            Zone act7Home = new Zone("断桥营地", 2);
            Zone sarnRamparts = new Zone("奇迹之墙", 2);
            Zone act8Home = new Zone("萨恩营地", 2);
            Zone bloodAqueduct = new Zone("赤红通道", 2);
            Zone act9Home = new Zone("统治者之殿", 2);
            Zone act10Home = new Zone("奥瑞亚港", 2);

            add(new Zone("狮眼守望", 1), IconType.Town);
            add(new Zone("暮光海滩", 1), IconType.Wp);
            add(new Zone("海潮孤岛", 1), IconType.NoWp);
            add(new Zone("炙热盐沼", 1), IconType.NoWp);
            add(new Zone("海潮地穴", 1), IconType.Wp);
            add(new Zone("沉寂海崖", 1), IconType.Wp);
            add(new Zone("碎岩山坡", 1), IconType.Wp);
            add(new Zone("禁灵之狱下层", 1), IconType.Wp);
            add(new Zone("禁灵之狱上层", 1), IconType.NoWp);
            add(new Zone("监狱大门", 1), IconType.Wp);
            add(new Zone("魅影船墓", 1), IconType.Wp);
            add(new Zone("怨忿之窟", 1), IconType.Wp);
            add(new Zone("怨忿之窟深处", 1), IconType.NoWp);
            add(new Zone("南部森林", 1), IconType.Wp);
            add(new Zone("森林营地", 1), IconType.Town);
            add(new Zone("河道", 1), IconType.Wp);
            add(new Zone("西部密林", 1), IconType.Wp);
            add(new Zone("前哨原野", 1), IconType.NoWp);
            add(new Zone("危机叉路", 1), IconType.Wp);
            add(new Zone("罪孽之殿 1 层", 1), IconType.Wp);
            add(new Zone("罪孽之殿 2 层", 1), IconType.NoWp);
            add(new Zone("织网者巢穴", 1), IconType.NoWp);
            add(new Zone("河畔断桥", 1), IconType.Wp);
            add(new Zone("湿地", 1), IconType.Wp);
            add(new Zone("瓦尔废墟", 1), IconType.NoWp);
            add(new Zone("北部密林", 1), IconType.Wp);
            add(new Zone("洞穴", 1), IconType.Wp);
            add(new Zone("古金字塔", 1), IconType.NoWp);
            add(new Zone("萨恩城废墟", 1), IconType.Wp);
            add(new Zone("萨恩营地", 1), IconType.Town);
            add(new Zone("贫民窟", 1), IconType.NoWp);
            add(new Zone("火葬场", 1), IconType.Wp);
            add(new Zone("下水道", 1), IconType.Wp);
            add(new Zone("市集地带", 1), IconType.Wp);
            add(new Zone("激战广场", 1), IconType.Wp);
            add(new Zone("不朽海港", 1), IconType.Wp);
            add(new Zone("日耀神殿 1 层", 1), IconType.Wp);
            add(new Zone("日耀神殿 2 层", 1), IconType.Wp);
            add(new Zone("乌旗守卫兵营", 1), IconType.Wp);
            add(new Zone("月影神殿 1 层", 1), IconType.Wp);
            add(new Zone("月影神殿 2 层", 1), IconType.NoWp);
            add(new Zone("皇家花园", 1), IconType.Wp);
            add(new Zone("图书馆", 1), IconType.Wp);
            add(new Zone("神权之塔", 1), IconType.Wp);
            add(new Zone("上层神权之塔", 1), IconType.NoWp);
            add(new Zone("水道遗迹", 1), IconType.Wp);
            add(new Zone("统治者之殿", 1), IconType.Town);
            add(new Zone("干涸湖岸", 1), IconType.NoWp);
            add(new Zone("漆黑矿坑:第 1 层", 1), IconType.NoWp);
            add(new Zone("漆黑矿坑:第 2 层", 1), IconType.NoWp);
            add(new Zone("水晶矿脉", 1), IconType.Wp);
            add(new Zone("德瑞索的幻境", 1), IconType.NoWp);
            add(new Zone("冈姆的幻境", 1), IconType.NoWp);
            add(new Zone("冈姆的堡垒", 1), IconType.Wp);
            add(new Zone("大竞技场", 1), IconType.Wp);
            add(new Zone("巨兽沼泽 1 层", 1), IconType.NoWp);
            add(new Zone("巨兽沼泽 2 层", 1), IconType.NoWp);
            add(new Zone("育灵之室", 1), IconType.Wp);
            add(new Zone("奥瑞亚之道", 1), IconType.NoWp);
            add(new Zone("奴隶深坑", 1), IconType.Wp);
            add(new Zone("狱卒之塔", 1), IconType.Town);
            add(new Zone("控制区", 1), IconType.NoWp);
            add(new Zone("奥瑞亚广场", 1), IconType.Wp);
            add(new Zone("圣堂高庭", 1), IconType.Wp);
            add(new Zone("纯净圣殿", 1), IconType.Wp);
            add(new Zone("化作火海的高庭", 1), IconType.NoWp);
            add(new Zone("广场遗迹", 1), IconType.Wp);
            add(new Zone("藏古堂", 1), IconType.NoWp);
            add(new Zone("遗物圣所", 1), IconType.Wp);
            add(kitavaPart1Kill, IconType.Wp);
            add(act6Home, IconType.Town, kitavaPart1Kill);
            add(new Zone("暮光海滩", 2), IconType.Wp, act6Home);
            add(new Zone("炙热盐沼", 2), IconType.NoWp, act6Home);
            add(new Zone("卡鲁要塞", 2), IconType.NoWp, act6Home);
            add(new Zone("寂默山岭", 2), IconType.Wp, act6Home);
            add(new Zone("禁灵之狱下层", 2), IconType.Wp, act6Home);
            add(new Zone("薛朗之塔", 2), IconType.NoWp, act6Home);
            add(new Zone("监狱大门", 2), IconType.Wp, act6Home);
            add(new Zone("西部密林", 2), IconType.Wp, act6Home);
            add(new Zone("河道", 2), IconType.Wp, act6Home);
            add(new Zone("南部森林", 2), IconType.Wp, act6Home);
            add(new Zone("怨忿之窟深处", 2), IconType.NoWp, act6Home);
            add(new Zone("孤岛灯塔", 2), IconType.Wp, act6Home);
            add(new Zone("惊海之王的海礁", 2), IconType.Wp, act6Home);
            add(act7Home, IconType.Town);
            add(new Zone("河畔断桥", 2), IconType.NoWp, act7Home);
            add(new Zone("危机叉路", 2), IconType.Wp, act7Home);
            add(new Zone("堕道遗迹", 2), IconType.NoWp, act7Home);
            add(new Zone("寂静陵墓", 2), IconType.Wp, act7Home);
            add(new Zone("罪孽之殿 1 层", 2), IconType.Wp, act7Home);
            add(new Zone("马雷格罗的藏身处", 2), IconType.NoWp, act7Home);
            add(new Zone("罪孽之殿 2 层", 2), IconType.NoWp, act7Home);
            add(new Zone("兽穴", 2), IconType.Wp, act7Home);
            add(new Zone("灰原", 2), IconType.Wp, act7Home);
            add(new Zone("北部密林", 2), IconType.Wp, act7Home);
            add(new Zone("堤道", 2), IconType.Wp, act7Home);
            add(new Zone("瓦尔古城", 2), IconType.Wp, act7Home);
            add(new Zone("坠欲之殿 1 层", 2), IconType.NoWp, act7Home);
            add(new Zone("坠欲之殿 2 层", 2), IconType.NoWp, act7Home);
            add(sarnRamparts, IconType.Wp);
            add(act8Home, IconType.Town, sarnRamparts);
            add(new Zone("剧毒管道", 2), IconType.NoWp, act8Home);
            add(new Zone("德瑞的污水坑", 2), IconType.Wp, act8Home);
            add(new Zone("中转码头", 2), IconType.NoWp, act8Home);
            add(new Zone("稻穗之门", 2), IconType.Wp, act8Home);
            add(new Zone("帝国平原", 2), IconType.Wp, act8Home);
            add(new Zone("日耀神殿 1 层", 2), IconType.Wp, act8Home);
            add(new Zone("日耀神殿 2 层", 2), IconType.NoWp, act8Home);
            add(new Zone("日耀广场", 2), IconType.Wp, act8Home);
            add(new Zone("港湾大桥", 2), IconType.NoWp, act8Home);
            add(new Zone("月影广场", 2), IconType.Wp, act8Home);
            add(new Zone("月影神殿 1 层", 2), IconType.Wp, act8Home);
            add(new Zone("月影神殿 2 层", 2), IconType.NoWp, act8Home);
            add(new Zone("古兵工厂", 2), IconType.Wp, act8Home);
            add(bloodAqueduct, IconType.Wp);
            add(act9Home, IconType.Town, bloodAqueduct);
            add(new Zone("斜坡", 2), IconType.NoWp, act9Home);
            add(new Zone("贫瘠之地", 2), IconType.Wp, act9Home);
            add(new Zone("巨石丘陵", 2), IconType.Wp, act9Home);
            add(new Zone("隧道", 2), IconType.Wp, act9Home);
            add(new Zone("沸水湖泊", 2), IconType.NoWp, act9Home);
            add(new Zone("采石场", 2), IconType.Wp, act9Home);
            add(new Zone("精炼厂", 2), IconType.NoWp, act9Home);
            add(new Zone("巨兽沼泽", 2), IconType.NoWp, act9Home);
            add(new Zone("育灵之室", 2), IconType.NoWp, act9Home);
            add(act10Home, IconType.Town);
            add(new Zone("教堂顶楼", 2), IconType.NoWp, act10Home);
            add(new Zone("广场遗迹", 2), IconType.Wp, act10Home);
            add(new Zone("化作火海的高庭", 2), IconType.NoWp, act10Home);
            add(new Zone("亵渎之间", 2), IconType.Wp, act10Home);
            add(new Zone("遗物圣所", 2), IconType.Wp, act10Home);
            add(new Zone("藏骸运河", 2), IconType.NoWp, act10Home);
            add(new Zone("饲槽", 2), IconType.NoWp, act10Home);
            add(new Zone("卡鲁海滩", 2), IconType.Town, act10Home);
        }

        private static void add(Zone zone, IconType icon, Zone requirement = null)
        {
            ZONES.Add(zone);
            ICONTYPES[zone] = icon;
            REQUIRED[zone] = requirement;
        }

        // Creates a zone representation using the zone name.
        // Tries to guess the part using information about the encountered zones so far.
        public static IZone Parse(string zoneName, HashSet<IZone> encounteredZones)
        {
            return new Zone(zoneName, guessPart(zoneName, encounteredZones));
        }

        // Returns part 1 if the requirements for part 2 are not met. 2 otherwise.
        // Assuming the run started in act 1, if the previous zone requirements are not met for the part 2 equivalent, then we are certain that this is a part 1 zone.
        // Assuming runners don't go back to part 1 zones once in part 2, we are quite certain that this is a part 2 zone.
        // They may return to part 1 towns but returning part 2 instead would not cause more or fewer splits to occur.
        private static int guessPart(string zoneName, HashSet<IZone> encounteredZones)
        {
            Zone zone = new Zone(zoneName, 2);
            // Check to make sure that a part 2 version exists for this zone.
            if (REQUIRED.ContainsKey(zone))
            {
                Zone required = REQUIRED[zone];
                if (required == null || encounteredZones.Contains(required))
                {
                    return 2;
                }
            }
            return 1;
        }

        private string name;
        private int part;

        private Zone(string name, int part)
        {
            this.name = name;
            this.part = part;
        }

        public string Serialize()
        {
            return ToString();
        }

        public string SplitName()
        {
            if (part == 1)
            {
                return name;
            }
            return ToString();
        }

        public override string ToString()
        {
            return name + " (Part " + part + ")";
        }

        public override bool Equals(object obj)
        {
            Zone zone = obj as Zone;
            if (zone == null)
            {
                return false;
            }
            return name.Equals(zone.name) && part == zone.part;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() * 23 + part;
        }
    }
}
