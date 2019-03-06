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
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.ProfilePropertyResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.ProfilePropertyResource
{
	[ExpressType("IfcGeneralProfileProperties", 648)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcGeneralProfileProperties : IfcProfileProperties, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcGeneralProfileProperties>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcGeneralProfileProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcMassPerLengthMeasure? _physicalWeight;
		private IfcPositiveLengthMeasure? _perimeter;
		private IfcPositiveLengthMeasure? _minimumPlateThickness;
		private IfcPositiveLengthMeasure? _maximumPlateThickness;
		private IfcAreaMeasure? _crossSectionArea;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcMassPerLengthMeasure? @PhysicalWeight 
		{ 
			get 
			{
				if(_activated) return _physicalWeight;
				Activate();
				return _physicalWeight;
			} 
			set
			{
				SetValue( v =>  _physicalWeight = v, _physicalWeight, value,  "PhysicalWeight", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPositiveLengthMeasure? @Perimeter 
		{ 
			get 
			{
				if(_activated) return _perimeter;
				Activate();
				return _perimeter;
			} 
			set
			{
				SetValue( v =>  _perimeter = v, _perimeter, value,  "Perimeter", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveLengthMeasure? @MinimumPlateThickness 
		{ 
			get 
			{
				if(_activated) return _minimumPlateThickness;
				Activate();
				return _minimumPlateThickness;
			} 
			set
			{
				SetValue( v =>  _minimumPlateThickness = v, _minimumPlateThickness, value,  "MinimumPlateThickness", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcPositiveLengthMeasure? @MaximumPlateThickness 
		{ 
			get 
			{
				if(_activated) return _maximumPlateThickness;
				Activate();
				return _maximumPlateThickness;
			} 
			set
			{
				SetValue( v =>  _maximumPlateThickness = v, _maximumPlateThickness, value,  "MaximumPlateThickness", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcAreaMeasure? @CrossSectionArea 
		{ 
			get 
			{
				if(_activated) return _crossSectionArea;
				Activate();
				return _crossSectionArea;
			} 
			set
			{
				SetValue( v =>  _crossSectionArea = v, _crossSectionArea, value,  "CrossSectionArea", 7);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_physicalWeight = value.RealVal;
					return;
				case 3: 
					_perimeter = value.RealVal;
					return;
				case 4: 
					_minimumPlateThickness = value.RealVal;
					return;
				case 5: 
					_maximumPlateThickness = value.RealVal;
					return;
				case 6: 
					_crossSectionArea = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcGeneralProfileProperties other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@ProfileDefinition != null)
					yield return @ProfileDefinition;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}