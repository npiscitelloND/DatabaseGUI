﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DB_View
{
    class Database
    {
        private Windows.Storage.StorageFile _db_file;

        // disk reads are evil - it's not like it's gonna use too much memory anyways.
        private string _name = "";
        private string _description = "";
        private string _notes = "";
        private string _applications = "";
        private string _manufacturer = "";
        private string _supplier = "";

        public async void LoadFile(Action cb)
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker
            {
                SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary,
                ViewMode = Windows.Storage.Pickers.PickerViewMode.List
            };
            picker.FileTypeFilter.Add(".sqlite");
            picker.FileTypeFilter.Add("*");
            _db_file = await picker.PickSingleFileAsync();
            if( _db_file != null ) { cb(); }
        }

        public void LoadEntry()
        {

        }

        public string GetPath()
        {
            if( _db_file != null)
            {
                return _db_file.Path;
            }
            else
            {
                return "";
            }
        }

        public string GetName()
        {
            return _name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetNotes()
        {
            return _notes;
        }

        public string GetApplications()
        {
            return _applications;
        }

        public string GetManufacturer()
        {
            return _manufacturer;
        }

        public string GetSupplier()
        {
            return _supplier;
        }
    }
}
