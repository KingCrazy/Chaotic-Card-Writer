// Copyright 2018 github.com/KingCrazy
// A file containing a ton of constants used for reading the language files.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChaoticCardWriter
{
    class LanguageFileConsts
    {
        // Dictionary keys for accessing the values of the language file objects.
        // These correspond to the keys in the language JSON files. Do not change their values.

        public const string KEY_LANGUAGE = "language";
        public const string KEY_PROGRAM_TITLE = "title";

        // Menu keys
        public const string KEY_MENU_FILE = "menu_file";
        public const string KEY_MENU_WRITE_FROM_FILE = "menu_write_from_file";
        public const string KEY_MENU_SAVE_AS = "menu_save_as";
        public const string KEY_MENU_ABOUT = "menu_about";
        public const string KEY_MENU_LOAD_IMAGE = "menu_load_image";
        public const string KEY_MENU_HELP = "menu_help";
        public const string KEY_MENU_SETTINGS = "menu_settings";

        // Button keys
        public const string KEY_BUTTON_ADJUST = "button_adjust";
        public const string KEY_BUTTON_FONT = "button_font";
        public const string KEY_BUTTON_RESET = "button_reset";
        public const string KEY_BUTTON_RESET_ALL = "button_reset_all";
        public const string KEY_BUTTON_OK = "button_OK";
        public const string KEY_BUTTON_CANCEL = "button_cancel";
        public const string KEY_BUTTON_BROWSE = "button_browse";
        public const string KEY_BUTTON_DONE = "button_done";
        public const string KEY_BUTTON_WRITE = "button_write";

        // Label keys
        public const string KEY_LABEL_COURAGE = "label_courage";
        public const string KEY_LABEL_POWER = "label_power";
        public const string KEY_LABEL_WISDOM = "label_wisdom";
        public const string KEY_LABEL_SPEED = "label_speed";
        public const string KEY_LABEL_ENERGY = "label_energy";
        public const string KEY_LABEL_STATS_FILE = "lavel_stats_file";
        public const string KEY_LABEL_SOURCE_FOLDER = "label_source_folder";
        public const string KEY_LABEL_DESTINATION_FOLDER = "label_destination_folder";
        public const string KEY_LABEL_CARD_WRITER_COUNTER = "label_card_writer_counter";
        public const string KEY_LABEL_LOCALIZATION = "label_localization";
        public const string KEY_LABEL_VERSION = "label_version";
        public const string KEY_LABEL_FORMAT = "label_format";
        public const string KEY_LABEL_WARNING = "label_warning";

        // Description keys
        public const string KEY_DESC_STATS_FILE = "desc_stats_file";
        public const string KEY_DESC_SOURCE_FOLDER = "desc_source_folder";
        public const string KEY_DESC_DESTINATION_FOLDER = "desc_destination_folder";
        public const string KEY_DESC_PROGRAM = "desc_program";

        // Warning/Message keys
        public const string KEY_WARN_STATS_ODD = "warn_stats_odd";
        public const string KEY_WARN_STATS_ERROR = "warn_stats_error";
        public const string KEY_WARN_STATS_PATH_EMPTY = "warn_stats_path_empty";

    }
}
