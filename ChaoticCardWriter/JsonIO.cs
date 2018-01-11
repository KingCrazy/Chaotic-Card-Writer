// Copyright 2018 github.com/KingCrazy
// This file handles the JSON reading/writing involved with the program, specifically with language files and config files.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChaoticCardWriter
{
    enum FileTypeEnum
    {
        FT_CONFIG,
        FT_LANGUAGE,
        FT_TOTAL
    }

    class JsonIO
    {
        private const string CONFIG_FILE_DEFAULT = "{\n\"default_language\":\"english\",\n}";
        private const string LANG_FILE_DEFAULT = "{\n\"language\":\"English\",\n\"title\":\"Chaotic Card Writer\",\n\n\"menu_file\": \"File\",\n\"menu_write_from_file\":\"Write From File\",\n\"menu_save_as\":\"Save As\",\n\"menu_about\":\"About\",\n\"menu_load_image\":\"Load Image\",\n\"menu_settings\":\"Settings\",\n\"menu_help\":\"Help\",\n\n\"button_adjust\":\"Adjust\",\n\"button_font\":\"Font\",\n\"button_reset\":\"Reset\",\n\"button_reset_all\":\"Reset All\",\n\"button_OK\":\"OK\",\n\"button_cancel\":\"Cancel\",\n\"button_browse\":\"Browse\",\n\"button_done\":\"Done\",\n\"button_write\":\"Write\",\n\n\"label_courage\":\"Courage\",\n\"label_power\":\"Power\",\n\"label_wisdom\":\"Wisdom\",\n\"label_speed\":\"Speed\",\n\"label_energy\":\"Energy\",\n\"label_stats_file\":\"Stats File\",\n\"label_source_folder\":\"Source Folder\",\n\"label_destination_folder\":\"Destination Folder\",\n\"label_card_writer_counter\":\"Begin Counting:\",\n\"label_localization\":\"Localization\",\n\"label_version\":\"Version\",\n\"label_format\":\"Format\",\n\"label_warning\":\"Warning!\",\n\n\"desc_stats_file\":\"Select a file to generate cards from. See documentation for an example.\",\n\"desc_source_folder\":\"Select the directory in which your image files are located.\",\n\"desc_destination_folder\":\"Select the directory to save your cards in.\",\n\"desc_program\":\"Chaotic Card Writer is and application designed to assist users in writing numerical values onto images, for intended use with the Chaotic collectable card game.\n\nChaotic Card Writer is in no way affiliated with the Chaotic intellectual property, TV show, collectable card game, online services, or development team. All rights to the Chaotic trademark, logo, artwork, or anything associated with the intellectual property are held by their respective owners.\n\nThis is an unofficial program, designed for free, public distribution. No profits have been made from this application.\",\n\n\"warn_stats_odd\":\"Warning: An odd number of lines was detected in the stats file. One or more cards may have incorrect stats, or may not have been written at all.\",\n\"warn_stats_error\":\"Oops! There was an error writing the files. One or more files may not have been successfully written. Check to make sure your stats file is formatted correctly.\",\n\"warn_stats_path_empty\":\"One or more paths are empty.\",\n}\n";

        public const string CONFIG_PATH = "config.json";
        public const string LANGUAGE_PATH = "languages";

        // This function reads in a filename of a JSON file, deserializes the data into a dictionary, and returns a JsonFileObject containing the data.
        public static JsonFileObject ReadJsonFile(string filename, bool createIfNull, FileTypeEnum fileType = FileTypeEnum.FT_LANGUAGE)
        {
            JsonFileObject returnObj = new JsonFileObject();
            if (File.Exists(filename)) {
                string json = ReadRawJson(filename);
                var data = JsonConvert.DeserializeObject<Dictionary<string, dynamic>>(json);
                returnObj.data = data as Dictionary<string, dynamic>;
            }
            else
            {
                if (createIfNull)
                {
                    CreateDefaultFile(fileType);
                }
            }
            return returnObj;
        }

        // Takes in a filename string, reads in the file, and returns the raw json text.
        public static string ReadRawJson(string filename)
        {
            string json;
            using (StreamReader reader = new StreamReader(filename))
            {
                json = reader.ReadToEnd();
                
                reader.Close();
            }
            return json;
        }

        // Creates a default file of the given type.
        public static void CreateDefaultFile(FileTypeEnum fileType)
        {
            string stringToWrite = "";
            string newFileName = "";
            switch (fileType)
            {
                case FileTypeEnum.FT_CONFIG:
                    stringToWrite = CONFIG_FILE_DEFAULT;
                    newFileName = CONFIG_PATH;
                    break;
                case FileTypeEnum.FT_LANGUAGE:
                    stringToWrite = LANG_FILE_DEFAULT;
                    newFileName = string.Format("{0}\\english.json", LANGUAGE_PATH);
                    break;
                default:
                    break;
            }

            using (FileStream fs = File.Create(newFileName))
            {
                fs.Write(new UTF8Encoding(true).GetBytes(stringToWrite), 0, stringToWrite.Length);
                fs.Close();
            }
        }

        // Serializes the json object passed in, and writes it to the given path.
        private static bool WriteToJson(string path, object json)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.Formatting = Formatting.Indented;

            try {
                using (StreamWriter sw = new StreamWriter(path))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, json);
                    sw.Close();
                    writer.Close();
                }

                return true;
            } catch(Exception e)
            {
                Console.WriteLine("Error writing to Json file. Error: {0}", e);
                return false;
            }
        }

        // Reads in the config file and returns a ConfigFile object.
        // Will create a default config file if none exists.
        public static ConfigFile ReadConfigFile()
        {
            ConfigFile cfg = null;
            if (!File.Exists(CONFIG_PATH))
            {
                CreateDefaultFile(FileTypeEnum.FT_CONFIG);
            }
            cfg = JsonConvert.DeserializeObject<ConfigFile>(ReadRawJson(CONFIG_PATH));

            return cfg;
       }

        // Writes to the referenced config file.
        public static bool WriteConfigFile(ref ConfigFile cfg)
        {
            return WriteToJson(CONFIG_PATH, cfg);
        }
    }

    class JsonFileObject
    {
        /// <summary>
        /// JSON data as a Key:Value pair. Direct access is not recommended. Use GetValue(string key) instead.
        /// </summary>
        public Dictionary<string, dynamic> data { get; set; }

        /// <summary>
        /// Gets the Dictionary value given a string key. Typically for use with the LocalizationFileConsts constants.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public string GetValue(string key)
        {
            string val = "";

            if (data.ContainsKey(key))
                val = data[key];

            return val;
        }
    }

}
