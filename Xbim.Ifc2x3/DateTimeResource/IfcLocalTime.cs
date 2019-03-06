// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.DateTimeResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.DateTimeResource
{
	[ExpressType("IfcLocalTime", 483)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLocalTime : PersistEntity, IInstantiableEntity, IfcDateTimeSelect, IfcObjectReferenceSelect, IContainsEntityReferences, IEquatable<@IfcLocalTime>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLocalTime(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcHourInDay _hourComponent;
		private IfcMinuteInHour? _minuteComponent;
		private IfcSecondInMinute? _secondComponent;
		private IfcCoordinatedUniversalTimeOffset _zone;
		private IfcDaylightSavingHour? _daylightSavingOffset;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcHourInDay @HourComponent 
		{ 
			get 
			{
				if(_activated) return _hourComponent;
				Activate();
				return _hourComponent;
			} 
			set
			{
				SetValue( v =>  _hourComponent = v, _hourComponent, value,  "HourComponent", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcMinuteInHour? @MinuteComponent 
		{ 
			get 
			{
				if(_activated) return _minuteComponent;
				Activate();
				return _minuteComponent;
			} 
			set
			{
				SetValue( v =>  _minuteComponent = v, _minuteComponent, value,  "MinuteComponent", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcSecondInMinute? @SecondComponent 
		{ 
			get 
			{
				if(_activated) return _secondComponent;
				Activate();
				return _secondComponent;
			} 
			set
			{
				SetValue( v =>  _secondComponent = v, _secondComponent, value,  "SecondComponent", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcCoordinatedUniversalTimeOffset @Zone 
		{ 
			get 
			{
				if(_activated) return _zone;
				Activate();
				return _zone;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _zone = v, _zone, value,  "Zone", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcDaylightSavingHour? @DaylightSavingOffset 
		{ 
			get 
			{
				if(_activated) return _daylightSavingOffset;
				Activate();
				return _daylightSavingOffset;
			} 
			set
			{
				SetValue( v =>  _daylightSavingOffset = v, _daylightSavingOffset, value,  "DaylightSavingOffset", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_hourComponent = value.IntegerVal;
					return;
				case 1: 
					_minuteComponent = value.IntegerVal;
					return;
				case 2: 
					_secondComponent = value.RealVal;
					return;
				case 3: 
					_zone = (IfcCoordinatedUniversalTimeOffset)(value.EntityVal);
					return;
				case 4: 
					_daylightSavingOffset = value.IntegerVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLocalTime other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Zone != null)
					yield return @Zone;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}