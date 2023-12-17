﻿//  Copyright 2014 Craig Courtney
//  Copyright 2023 Helios Contributors
//    
//  Helios is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Helios is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace GadrocsWorkshop.Helios.Gauges.F15E.UFC
{
    using GadrocsWorkshop.Helios.ComponentModel;
    using GadrocsWorkshop.Helios.Controls;
    using GadrocsWorkshop.Helios.Interfaces.DCS.F15E;
    using System;
    using System.Windows;
    using System.Windows.Media;

    [HeliosControl("Helios.F15E.UFC.PILOT.ODU", "UFC ODU (Pilot)", "F-15E Strike Eagle", typeof(BackgroundImageRenderer), HeliosControlFlags.NotShownInUI)]
    public class UFC_Pilot_ODU : UFC
    {
        public UFC_Pilot_ODU()
            : base("UFC Panel (Pilot)", Cockpit.Pilot, UFCType.ODU, new Size(654, 407))
        {
        }
    }
}
