﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.gdfgj88
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Animal.
    /// </summary>
    //  *** Start programmer edit section *** (Animal CustomAttributes)

    //  *** End programmer edit section *** (Animal CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AnimalE", new string[] {
            "Weight as \'Weight\'"})]
    [View("AnimalL", new string[] {
            "Weight as \'Weight\'"})]
    public class Animal : ICSSoft.STORMNET.DataObject
    {
        
        private double fWeight;
        
        //  *** Start programmer edit section *** (Animal CustomMembers)

        //  *** End programmer edit section *** (Animal CustomMembers)

        
        /// <summary>
        /// Weight.
        /// </summary>
        //  *** Start programmer edit section *** (Animal.Weight CustomAttributes)

        //  *** End programmer edit section *** (Animal.Weight CustomAttributes)
        public virtual double Weight
        {
            get
            {
                //  *** Start programmer edit section *** (Animal.Weight Get start)

                //  *** End programmer edit section *** (Animal.Weight Get start)
                double result = this.fWeight;
                //  *** Start programmer edit section *** (Animal.Weight Get end)

                //  *** End programmer edit section *** (Animal.Weight Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Animal.Weight Set start)

                //  *** End programmer edit section *** (Animal.Weight Set start)
                this.fWeight = value;
                //  *** Start programmer edit section *** (Animal.Weight Set end)

                //  *** End programmer edit section *** (Animal.Weight Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AnimalE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AnimalE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AnimalE", typeof(IIS.gdfgj88.Animal));
                }
            }
            
            /// <summary>
            /// "AnimalL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AnimalL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AnimalL", typeof(IIS.gdfgj88.Animal));
                }
            }
        }
    }
}
