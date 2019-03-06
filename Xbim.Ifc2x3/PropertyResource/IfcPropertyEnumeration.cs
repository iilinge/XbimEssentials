// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PropertyResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PropertyResource
{
	[ExpressType("IfcPropertyEnumeration", 597)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcPropertyEnumeration : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcPropertyEnumeration>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPropertyEnumeration(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_enumerationValues = new ItemSet<IfcValue>( this, 0,  2);
		}

		#region Explicit attribute fields
		private IfcLabel _name;
		private readonly ItemSet<IfcValue> _enumerationValues;
		private IfcUnit _unit;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel @Name 
		{ 
			get 
			{
				if(_activated) return _name;
				Activate();
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.ListUnique, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcValue> @EnumerationValues 
		{ 
			get 
			{
				if(_activated) return _enumerationValues;
				Activate();
				return _enumerationValues;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcUnit @Unit 
		{ 
			get 
			{
				if(_activated) return _unit;
				Activate();
				return _unit;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 3);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_name = value.StringVal;
					return;
				case 1: 
					_enumerationValues.InternalAdd((IfcValue)value.EntityVal);
					return;
				case 2: 
					_unit = (IfcUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPropertyEnumeration other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Unit != null)
					yield return @Unit;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}