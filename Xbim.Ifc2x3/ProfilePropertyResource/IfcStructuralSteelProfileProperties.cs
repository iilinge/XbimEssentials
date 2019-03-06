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
	[ExpressType("IfcStructuralSteelProfileProperties", 692)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcStructuralSteelProfileProperties : IfcStructuralProfileProperties, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcStructuralSteelProfileProperties>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcStructuralSteelProfileProperties(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcAreaMeasure? _shearAreaZ;
		private IfcAreaMeasure? _shearAreaY;
		private IfcPositiveRatioMeasure? _plasticShapeFactorY;
		private IfcPositiveRatioMeasure? _plasticShapeFactorZ;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(24, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 24)]
		public IfcAreaMeasure? @ShearAreaZ 
		{ 
			get 
			{
				if(_activated) return _shearAreaZ;
				Activate();
				return _shearAreaZ;
			} 
			set
			{
				SetValue( v =>  _shearAreaZ = v, _shearAreaZ, value,  "ShearAreaZ", 24);
			} 
		}	
		[EntityAttribute(25, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 25)]
		public IfcAreaMeasure? @ShearAreaY 
		{ 
			get 
			{
				if(_activated) return _shearAreaY;
				Activate();
				return _shearAreaY;
			} 
			set
			{
				SetValue( v =>  _shearAreaY = v, _shearAreaY, value,  "ShearAreaY", 25);
			} 
		}	
		[EntityAttribute(26, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 26)]
		public IfcPositiveRatioMeasure? @PlasticShapeFactorY 
		{ 
			get 
			{
				if(_activated) return _plasticShapeFactorY;
				Activate();
				return _plasticShapeFactorY;
			} 
			set
			{
				SetValue( v =>  _plasticShapeFactorY = v, _plasticShapeFactorY, value,  "PlasticShapeFactorY", 26);
			} 
		}	
		[EntityAttribute(27, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 27)]
		public IfcPositiveRatioMeasure? @PlasticShapeFactorZ 
		{ 
			get 
			{
				if(_activated) return _plasticShapeFactorZ;
				Activate();
				return _plasticShapeFactorZ;
			} 
			set
			{
				SetValue( v =>  _plasticShapeFactorZ = v, _plasticShapeFactorZ, value,  "PlasticShapeFactorZ", 27);
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
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
				case 9: 
				case 10: 
				case 11: 
				case 12: 
				case 13: 
				case 14: 
				case 15: 
				case 16: 
				case 17: 
				case 18: 
				case 19: 
				case 20: 
				case 21: 
				case 22: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 23: 
					_shearAreaZ = value.RealVal;
					return;
				case 24: 
					_shearAreaY = value.RealVal;
					return;
				case 25: 
					_plasticShapeFactorY = value.RealVal;
					return;
				case 26: 
					_plasticShapeFactorZ = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcStructuralSteelProfileProperties other)
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