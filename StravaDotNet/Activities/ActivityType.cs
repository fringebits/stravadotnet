#region Copyright (C) 2014-2016 Sascha Simon

//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see http://www.gnu.org/licenses/.
//
//  Visit the official homepage at http://www.sascha-simon.com

#endregion

// Updated list of activities, based on
// https://support.strava.com/hc/en-us/articles/216919407-Supported-Sport-Types-on-Strava
//

namespace Strava.Activities
{
    /// <summary>
    /// The type of an activity.
    /// </summary>
    public enum ActivityType
    {
        // Foot Sports
        Run,
        TrailRun,
        Walk,
        Hike,
        VirtualRun,
        //Cycle Sports
        Ride,
        MountainBikeRide,
        GravelBikeRide,
        EBikeRide,
        EMountainBikeRide,
        Velomobile,
        VirtualRide,
        //Water Sports
        Canoe,
        Kayak,
        KitesurfSession,
        Row,
        StandUpPaddle,
        Surf,
        Swim,
        WindsurfSession,
        //Winter Sports
        IceSkate,
        AlpineSki,
        BackcountrySki,
        NordicSki,
        Snowboard,
        Snowshoe,
        //Other Sports
        Golf,
        Handcycle,
        InlineSkate,
        RockClimb,
        RollerSki,
        Wheelchair,
        Crossfit,
        Elliptical,
        Sailing,
        Skateboarding,
        Soccer,
        StairStepper,
        WeightTraining,
        Yoga,
        Workout,
        Tennis,
        Pickleball,
        Racquetball,
        Squash,
        Badminton,
        TableTennis,
        HIIT,
        Pilates,
        VirtualRow,
    }
}