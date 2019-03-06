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
using Xbim.Ifc2x3.ProfilePropertyResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IfcSectionReinforcementProperties", 508)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSectionReinforcementProperties : PersistEntity, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcSectionReinforcementProperties>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSectionReinforcementProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_crossSectionReinforcementDefinitions = new ItemSet<IfcReinforcementBarProperties>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _longitudinalStartPosition;
		private IfcLengthMeasure _longitudinalEndPosition;
		private IfcLengthMeasure? _transversePosition;
		private IfcReinforcingBarRoleEnum _reinforcementRole;
		private IfcSectionProperties _sectionDefinition;
		private readonly ItemSet<IfcReinforcementBarProperties> _crossSectionReinforcementDefinitions;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 1)]
		public IfcLengthMeasure @LongitudinalStartPosition 
		{ 
			get 
			{
				if(_activated) return _longitudinalStartPosition;
				Activate();
				return _longitudinalStartPosition;
			} 
			set
			{
				SetValue( v =>  _longitudinalStartPosition = v, _longitudinalStartPosition, value,  "LongitudinalStartPosition", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLengthMeasure @LongitudinalEndPosition 
		{ 
			get 
			{
				if(_activated) return _longitudinalEndPosition;
				Activate();
				return _longitudinalEndPosition;
			} 
			set
			{
				SetValue( v =>  _longitudinalEndPosition = v, _longitudinalEndPosition, value,  "LongitudinalEndPosition", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcLengthMeasure? @TransversePosition 
		{ 
			get 
			{
				if(_activated) return _transversePosition;
				Activate();
				return _transversePosition;
			} 
			set
			{
				SetValue( v =>  _transversePosition = v, _transversePosition, value,  "TransversePosition", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 4)]
		public IfcReinforcingBarRoleEnum @ReinforcementRole 
		{ 
			get 
			{
				if(_activated) return _reinforcementRole;
				Activate();
				return _reinforcementRole;
			} 
			set
			{
				SetValue( v =>  _reinforcementRole = v, _reinforcementRole, value,  "ReinforcementRole", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcSectionProperties @SectionDefinition 
		{ 
			get 
			{
				if(_activated) return _sectionDefinition;
				Activate();
				return _sectionDefinition;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _sectionDefinition = v, _sectionDefinition, value,  "SectionDefinition", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 6)]
		public IItemSet<IfcReinforcementBarProperties> @CrossSectionReinforcementDefinitions 
		{ 
			get 
			{
				if(_activated) return _crossSectionReinforcementDefinitions;
				Activate();
				return _crossSectionReinforcementDefinitions;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_longitudinalStartPosition = value.RealVal;
					return;
				case 1: 
					_longitudinalEndPosition = value.RealVal;
					return;
				case 2: 
					_transversePosition = value.RealVal;
					return;
				case 3: 
                    _reinforcementRole = (IfcReinforcingBarRoleEnum) System.Enum.Parse(typeof (IfcReinforcingBarRoleEnum), value.EnumVal, true);
					return;
				case 4: 
					_sectionDefinition = (IfcSectionProperties)(value.EntityVal);
					return;
				case 5: 
					_crossSectionReinforcementDefinitions.InternalAdd((IfcReinforcementBarProperties)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSectionReinforcementProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@SectionDefinition != null)
					yield return @SectionDefinition;
				foreach(var entity in @CrossSectionReinforcementDefinitions)
					yield return entity;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}