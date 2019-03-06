// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PropertyResource;
using Xbim.Ifc2x3.MeasureResource;
using Xbim.Ifc2x3.DateTimeResource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.CostResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.CostResource
{
	[ExpressType("IfcAppliedValue", 79)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcAppliedValue : PersistEntity, IfcObjectReferenceSelect, IEquatable<@IfcAppliedValue>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcAppliedValue(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcAppliedValueSelect _appliedValue;
		private IfcMeasureWithUnit _unitBasis;
		private IfcDateTimeSelect _applicableDate;
		private IfcDateTimeSelect _fixedUntilDate;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLabel? @Name 
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
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(_activated) return _description;
				Activate();
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcAppliedValueSelect @AppliedValue 
		{ 
			get 
			{
				if(_activated) return _appliedValue;
				Activate();
				return _appliedValue;
			} 
			set
			{
				var entity = value as IPersistEntity;
				if (entity != null && !(ReferenceEquals(Model, entity.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _appliedValue = v, _appliedValue, value,  "AppliedValue", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 4)]
		public IfcMeasureWithUnit @UnitBasis 
		{ 
			get 
			{
				if(_activated) return _unitBasis;
				Activate();
				return _unitBasis;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _unitBasis = v, _unitBasis, value,  "UnitBasis", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcDateTimeSelect @ApplicableDate 
		{ 
			get 
			{
				if(_activated) return _applicableDate;
				Activate();
				return _applicableDate;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _applicableDate = v, _applicableDate, value,  "ApplicableDate", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcDateTimeSelect @FixedUntilDate 
		{ 
			get 
			{
				if(_activated) return _fixedUntilDate;
				Activate();
				return _fixedUntilDate;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _fixedUntilDate = v, _fixedUntilDate, value,  "FixedUntilDate", 6);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ReferencingValues")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 7)]
		public IEnumerable<IfcReferencesValueDocument> @ValuesReferenced 
		{ 
			get 
			{
				return Model.Instances.Where<IfcReferencesValueDocument>(e => e.ReferencingValues != null &&  e.ReferencingValues.Contains(this), "ReferencingValues", this);
			} 
		}
		[InverseProperty("ComponentOfTotal")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 8)]
		public IEnumerable<IfcAppliedValueRelationship> @ValueOfComponents 
		{ 
			get 
			{
				return Model.Instances.Where<IfcAppliedValueRelationship>(e => Equals(e.ComponentOfTotal), "ComponentOfTotal", this);
			} 
		}
		[InverseProperty("Components")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 9)]
		public IEnumerable<IfcAppliedValueRelationship> @IsComponentIn 
		{ 
			get 
			{
				return Model.Instances.Where<IfcAppliedValueRelationship>(e => e.Components != null &&  e.Components.Contains(this), "Components", this);
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
					_description = value.StringVal;
					return;
				case 2: 
					_appliedValue = (IfcAppliedValueSelect)(value.EntityVal);
					return;
				case 3: 
					_unitBasis = (IfcMeasureWithUnit)(value.EntityVal);
					return;
				case 4: 
					_applicableDate = (IfcDateTimeSelect)(value.EntityVal);
					return;
				case 5: 
					_fixedUntilDate = (IfcDateTimeSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcAppliedValue other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}