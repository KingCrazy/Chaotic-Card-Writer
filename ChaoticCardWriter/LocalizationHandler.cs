// Copyright 2018 github.com/KingCrazy
// This file handles the localization of the program, loading in and storing language files.

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
    class LocalizationHandler
    {

        public List<LangFileObject> languageFiles = new List<LangFileObject>();

        public LocalizationHandler()
        {
            LoadLanguages();
        }

        // Loads all languages in the /languages folder.
        public void LoadLanguages()
        {
            LangFileObject languageFile;

            //Console.WriteLine(string.Format("Language files found: {0}", Directory.GetFiles(JsonIO.LANGUAGE_PATH).Length)); // Debug garbage.

            // checks to see if the directory exists. If not, we will create it.
            if (!Directory.Exists(JsonIO.LANGUAGE_PATH))
            {
                Directory.CreateDirectory(JsonIO.LANGUAGE_PATH);
            }

            try {
                // We'll clear the list of languages first, in case we're reloading.
                languageFiles.Clear();

                // We run through the list of language JSON files in the languages folder.
                foreach (string path in Directory.GetFiles(JsonIO.LANGUAGE_PATH))
                {
                    if (path.Contains(".json")) // If it's a .json file...
                    {
                        // Create a new language object. If this isn't here, the languageFile data and ID are never updated.
                        languageFile = new LangFileObject();
                        // Console.WriteLine("Language file: {0}", path); // Debug garbage.
                        languageFile.data = JsonIO.ReadJsonFile(path, false).data;
                        languageFile.id = languageFile.GetValue(LanguageFileConsts.KEY_LANGUAGE);

                        // Make sure we're not loading a duplicate.
                        if (!CheckLanguageWithIdIsValid(languageFile.id))
                            languageFiles.Add(languageFile);
                        else
                            Console.WriteLine("Language file with this ID already exists.");
                    }
                }
            } catch(Exception e)
            {
                Console.WriteLine(string.Format("Unable to load language files. Error: {0}", e));
            }
        }

        // Returns a language file object's index in the list of language file objects given its ID.
        // Returns -1 if the language was not found.
        public int GetLanguageFileIndexById(string id)
        {
            int index = -1;
            if (languageFiles.Count > 0)
            {
                for (int i = 0; i < languageFiles.Count; i++)
                {
                    if (languageFiles[i].id.Equals(id))
                    {
                        index = i;
                    }

                }
            }
            return index;
        }

        // Returns a language file object by its ID
        public LangFileObject GetLanguageById(string id)
        {
            LangFileObject lang = null;
            if (CheckLanguageWithIdIsValid(id))
            {
                foreach (LangFileObject fi in languageFiles)
                {
                    if (fi.id.Equals(id))
                    {
                        lang = fi;
                        break;
                    }
                }
            }
            return lang;
        }

        // Checks to see if a language with the given ID is valid. Returns true if valid, false otherwise.
        // Also checks to see if the language files list is empty.
        public bool CheckLanguageWithIdIsValid(string id)
        {
            if (languageFiles.Count > 0)
                return (GetLanguageFileIndexById(id) > -1);
            else
                return false;
        }

        // Loads the default language. If the language does not exist, it will create a default one.
        public void LoadDefaultLanguage(string languageId)
        {
            if (!CheckLanguageWithIdIsValid(languageId))
            {
                Console.WriteLine(string.Format("Language with ID {0} does not exist. Creating language file.", languageId));
                JsonIO.CreateDefaultFile(FileTypeEnum.FT_LANGUAGE);
                LoadLanguages();
            }
            Program.language = GetLanguageById(languageId);
        }
    }

    // An object designed to hold the necessary data for accessing language documents.
    class LangFileObject : JsonFileObject
    {
        public LangFileObject() { }
        public LangFileObject(Dictionary<string,dynamic> jsonData)
        {
            id = jsonData[LanguageFileConsts.KEY_LANGUAGE];
        }
        public string id { get; set; }
    }
}
