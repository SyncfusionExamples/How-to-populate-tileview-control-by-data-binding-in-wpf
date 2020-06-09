using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TileViewControl_DB
{
    public class Model
    {
        private string _header;
        public string Header
        {
            get
            { return _header; }

            set
            {
                _header = value;
            }
        }

        private string _content;
        public string Content
        {
            get
            { return _content; }

            set
            {
                _content = value;
            }
        }
        private Brush _backColor;
        public Brush BackColor
        {
            get
            { return _backColor; }

            set
            {
                _backColor = value;
            }
        }
    }
}
