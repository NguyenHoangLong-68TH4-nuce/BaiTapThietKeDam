using System;
using System.Collections.Generic;

namespace BaiTapThietKeDam.Models
{
    public class Beam
    {
        #region Fields
        private string _id;
        private string _mark;
        private string _story;
        private double _length;
        private double _volume;
        private EtabsAPI_Frame _frame;
        #endregion

        // Properties
        public string Id { get => _id; set => _id = value; }
        public string Mark { get => _mark; set => _mark = value; }
        public string Story { get => _story; set => _story = value; }
        public double Length { get => _length; set => _length = value; }
        public double Volume { get => _volume; set => _volume = value; } // Đã sửa lỗi thiếu } ở đây
        public EtabsAPI_Frame Frame { get => _frame; set => _frame = value; }

        // Constructor - Để public để các class khác khởi tạo được
        public Beam(string id, string mark, string story)
        {
            _id = id;
            _mark = mark;
            _story = story;
        }
    }
}