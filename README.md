# OsuRTDataProviderDLL
This is an edited fork repository from OsuRTDataProvider.
It supports OSU! and OSU!Tourney.  
  
OsuRTDataProvider can be obtained from [OSU!](https://osu.ppy.sh)(Stable Only):
* Beatmap
* Game Status
* Accuracy
* Health Point
* Combo
* 300  Count
* 100  Count
* 50   Count
* Miss Count
* Katu Count
* Geki Count
* Mods
* Play Time
* Score
* Game Mode

OSU! Clinet Version Requirements: **b20190816 After**  

# How to use?
Build this repository from the source in Visual Studio.  
Then, use the output dll.

You can use this dll in Python (with pythonnet) or any other language. But you have to enable this plugin from `OsuRTDataProviderPlugin.Enable` in namespace `OsuRTDataProvider` to enable.

# API
#### OsuRTDataProviderPlugin ***class***
##### Property
```csharp
        public OsuListenerManager ListenerManager;

        //If EnableTourneyMode = false in config.ini, return null.
        public OsuListenerManager[] TourneyListenerManagers;
        public int TourneyListenerManagersCount;
```
#### OsuListenerManager ***class***
##### Event
```csharp
        public delegate void OnBeatmapChangedEvt(Beatmap map);
        public delegate void OnHealthPointChangedEvt(double hp);
        public delegate void OnAccuracyChangedEvt(double acc);
        public delegate void OnComboChangedEvt(int combo);
        public delegate void OnModsChangedEvt(ModsInfo mods);
        public delegate void OnPlayingTimeChangedEvt(int ms);
        public delegate void OnHitCountChangedEvt(int hit);
        public delegate void OnStatusChangedEvt(OsuStatus last_status, OsuStatus status);
        public delegate void OnErrorStatisticsChangedEvt(ErrorStatisticsResult result);
        public delegate void OnPlayerChangedEvt(string player);
        public delegate void OnHitEventsChangedEvt(PlayType playType, List<HitEvent> hitEvents);

        /// <summary>
        /// Available at Playing and Linsten.
        /// If too old beatmap, map.ID = -1.
        /// </summary>
        public event OnBeatmapChangedEvt OnBeatmapChanged;

        /// <summary>
        /// Available at Playing.
        /// </summary>
        public event OnHealthPointChangedEvt OnHealthPointChanged;

        /// <summary>
        /// Available at Playing.
        /// </summary>
        public event OnAccuracyChangedEvt OnAccuracyChanged;

        /// <summary>
        /// Available at Playing.
        /// </summary>
        public event OnComboChangedEvt OnComboChanged;

        /// <summary>
        /// Available at Playing.
        /// if OsuStatus turns Listen , mods = ModsInfo.Empty
        /// </summary>
        public event OnModsChangedEvt OnModsChanged;

        /// <summary>
        /// Available at Playing and Listen.
        /// </summary>
        public event OnPlayingTimeChangedEvt OnPlayingTimeChanged;

        /// <summary>
        /// Available at Playing.
        /// </summary>
        public event OnHitCountChangedEvt On300HitChanged;

        /// <summary>
        /// Available at Playing.
        /// </summary>
        public event OnHitCountChangedEvt On100HitChanged;

        /// <summary>
        /// Available at Playing.
        /// </summary>
        public event OnHitCountChangedEvt On50HitChanged;

        /// <summary>
        /// Available at Playing.
        /// </summary>
        public event OnHitCountChangedEvt OnMissHitChanged;

        /// <summary>
        /// Available at Any.
        /// </summary>
        public event OnStatusChangedEvt OnStatusChanged;

        /// <summary>
        /// Get ErrorStatistics(UnstableRate and Error Hit).
        /// </summary>
        public event OnErrorStatisticsChangedEvt OnErrorStatisticsChanged;

        /// <summary>
        /// Get player name in playing.
        /// </summary>
        public event OnPlayerChangedEvt OnPlayerChanged;

        /// <summary>
        /// Get play type and hit events in playing. (https://osu.ppy.sh/help/wiki/osu!_File_Formats/Osr_(file_format))
        /// </summary>
        public event OnHitEventsChangedEvt OnHitEventsChanged;
```

##### OsuStatus ***enum***
```csharp
        public enum OsuStatus
        {
            NoFoundProcess,
            Unkonwn,
            Listening,
            Playing,
            Editing,
            Rank
        }
```
