using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace OsuRTDataProvider
{
    public class DefaultLanguage : I18nProvider
    {
        public static LanguageElement LANG_OSU_NOT_FOUND = "[ID:{0}]Not found osu!.exe process";
        public static LanguageElement LANG_OSU_FOUND = "[ID:{0}]Found osu!.exe process";
        public static LanguageElement LANG_TOURNEY_HINT = "Tourney Mode: {0}";

        public static LanguageElement CHECK_GOTO_RELEASE_PAGE_HINT = "Enter \"ortdp releases\" to open the releases page in your browser.";
        public static LanguageElement LANG_CHECK_ORTDP_UPDATE = "Found a new version of OsuRTDataProvider({0})";
        public static LanguageElement LANG_INIT_STATUS_FINDER_FAILED = "[ID:{0}]Init StatusFinder Failed! Retry after {1} seconds";
        public static LanguageElement LANG_INIT_STATUS_FINDER_SUCCESS = "[ID:{0}]Init StatusFinder Success!";
        public static LanguageElement LANG_INIT_PLAY_FINDER_FAILED = "[ID:{0}]Init PlayFinder Failed! Retry after {1} seconds";
        public static LanguageElement LANG_INIT_PLAY_FINDER_SUCCESS = "[ID:{0}]Init PlayFinder Success!";
        public static LanguageElement LANG_INIT_BEATMAP_FINDER_FAILED = "[ID:{0}]Init BeatmapFinder Failed! Retry after {1} seconds";
        public static LanguageElement LANG_INIT_BEATMAP_FINDER_SUCCESS = "[ID:{0}]Init BeatmapFinder Success!";
        public static LanguageElement LANG_INIT_MODE_FINDER_FAILED = "[ID:{0}]Init ModeFinder Failed! Retry after {1} seconds";
        public static LanguageElement LANG_INIT_MODE_FINDER_SUCCESS = "[ID:{0}]Init ModeFinder Success!";
        public static LanguageElement LANG_INIT_HIT_EVENT_SUCCESS = "[ID:{0}]Init HitEventFinder Success!";
        public static LanguageElement LANG_INIT_HIT_EVENT_FAIL = "[ID:{0}]Init HitEventFinder Failed! Retry after {1} seconds";

        public static LanguageElement LANG_BEATMAP_NOT_FOUND = "Beatmap not found";
    }

    public interface I18nProvider
    {

    }

    public struct LanguageElement
    {
        private string value;

        public LanguageElement(string defaultVal)
        {
            value = defaultVal;
        }

        public static implicit operator LanguageElement(string val)
        {
            return new LanguageElement(val);
        }

        public static implicit operator string(LanguageElement element)
        {
            return element.value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}