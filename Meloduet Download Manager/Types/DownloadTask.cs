using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Meloduet_Download_Manager.Types
{
    public class DownloadTask
    {
        public string _sourceUri;
        public string _fileName;
        public string _description;
        public long _size;
        public int _timeLeft;
        public int _speed;

        public DateTime _createDateTime;
        public DateTime _lastConnectDateTime;
        public TaskState _state;
        public TaskCategory _category;

    }
}
