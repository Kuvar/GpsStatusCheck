using System;
using System.Collections.Generic;
using System.Text;

namespace GpsStatusCheck.Services
{
    public interface IGpsDependencyService
    {
        void OpenSettings();
        bool IsGpsEnable();
    }
}
