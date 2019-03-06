// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationOrganizationResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationOrganizationResource
{
	[ExpressType("IfcLightSourceSpot", 760)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcLightSourceSpot : IfcLightSourcePositional, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcLightSourceSpot>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcLightSourceSpot(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcDirection _orientation;
		private IfcReal? _concentrationExponent;
		private IfcPositivePlaneAngleMeasure _spreadAngle;
		private IfcPositivePlaneAngleMeasure _beamWidthAngle;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 12)]
		public IfcDirection @Orientation 
		{ 
			get 
			{
				if(_activated) return _orientation;
				Activate();
				return _orientation;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 13)]
		public IfcReal? @ConcentrationExponent 
		{ 
			get 
			{
				if(_activated) return _concentrationExponent;
				Activate();
				return _concentrationExponent;
			} 
			set
			{
				SetValue( v =>  _concentrationExponent = v, _concentrationExponent, value,  "ConcentrationExponent", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 14)]
		public IfcPositivePlaneAngleMeasure @SpreadAngle 
		{ 
			get 
			{
				if(_activated) return _spreadAngle;
				Activate();
				return _spreadAngle;
			} 
			set
			{
				SetValue( v =>  _spreadAngle = v, _spreadAngle, value,  "SpreadAngle", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 15)]
		public IfcPositivePlaneAngleMeasure @BeamWidthAngle 
		{ 
			get 
			{
				if(_activated) return _beamWidthAngle;
				Activate();
				return _beamWidthAngle;
			} 
			set
			{
				SetValue( v =>  _beamWidthAngle = v, _beamWidthAngle, value,  "BeamWidthAngle", 13);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					_orientation = (IfcDirection)(value.EntityVal);
					return;
				case 10: 
					_concentrationExponent = value.RealVal;
					return;
				case 11: 
					_spreadAngle = value.RealVal;
					return;
				case 12: 
					_beamWidthAngle = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcLightSourceSpot other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@LightColour != null)
					yield return @LightColour;
				if (@Position != null)
					yield return @Position;
				if (@Orientation != null)
					yield return @Orientation;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}