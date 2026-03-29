using System;
using System.Collections.Generic;
using System.Collections.ObjectModel; // Quan trọng: Cần dòng này để dùng ObservableCollection

namespace BaiTapThietKeDam.Models
{
    public class EtabsAPI_Frame
    {
        private string _myName;
        private string _propName;
        private EtabsAPI_PropFrame _sectionProperty;
        private double _point1X;
        private double _point1Y;
        private double _point1Z;
        private ObservableCollection<EtabsAPI_FrameForce> _frameForces;

        public string MyName { get => _myName; set => _myName = value; }
        public string PropName { get => _propName; set => _propName = value; }
        public EtabsAPI_PropFrame SectionProperty { get => _sectionProperty; set => _sectionProperty = value; }
        public double Point1X { get => _point1X; set => _point1X = value; }
        public double Point1Y { get => _point1Y; set => _point1Y = value; }
        public double Point1Z { get => _point1Z; set => _point1Z = value; }

        public ObservableCollection<EtabsAPI_FrameForce> FrameForces
        {
            get => _frameForces;
            set => _frameForces = value;
        }

        public EtabsAPI_Frame()
        {
            _frameForces = new ObservableCollection<EtabsAPI_FrameForce>();
        }
    }
}