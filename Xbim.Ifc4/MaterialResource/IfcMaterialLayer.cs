// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.MaterialResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcMaterialLayer
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialLayer : IIfcMaterialDefinition
	{
		IIfcMaterial @Material { get; }
		IfcNonNegativeLengthMeasure @LayerThickness { get; }
		IfcLogical? @IsVentilated { get; }
		IfcLabel? @Name { get; }
		IfcText? @Description { get; }
		IfcLabel? @Category { get; }
		IfcNormalisedRatioMeasure? @Priority { get; }
		IIfcMaterialLayerSet @ToMaterialLayerSet {  get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[IndexedClass]
	[ExpressType("IFCMATERIALLAYER", 747)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialLayer : IfcMaterialDefinition, IInstantiableEntity, IIfcMaterialLayer, IEqualityComparer<@IfcMaterialLayer>, IEquatable<@IfcMaterialLayer>
	{
		#region IIfcMaterialLayer explicit implementation
		IIfcMaterial IIfcMaterialLayer.Material { get { return @Material; } }	
		IfcNonNegativeLengthMeasure IIfcMaterialLayer.LayerThickness { get { return @LayerThickness; } }	
		IfcLogical? IIfcMaterialLayer.IsVentilated { get { return @IsVentilated; } }	
		IfcLabel? IIfcMaterialLayer.Name { get { return @Name; } }	
		IfcText? IIfcMaterialLayer.Description { get { return @Description; } }	
		IfcLabel? IIfcMaterialLayer.Category { get { return @Category; } }	
		IfcNormalisedRatioMeasure? IIfcMaterialLayer.Priority { get { return @Priority; } }	
		 
		IIfcMaterialLayerSet IIfcMaterialLayer.ToMaterialLayerSet {  get { return @ToMaterialLayerSet; } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialLayer(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterial _material;
		private IfcNonNegativeLengthMeasure _layerThickness;
		private IfcLogical? _isVentilated;
		private IfcLabel? _name;
		private IfcText? _description;
		private IfcLabel? _category;
		private IfcNormalisedRatioMeasure? _priority;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMaterial @Material 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _material;
				((IPersistEntity)this).Activate(false);
				return _material;
			} 
			set
			{
				SetValue( v =>  _material = v, _material, value,  "Material");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNonNegativeLengthMeasure @LayerThickness 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _layerThickness;
				((IPersistEntity)this).Activate(false);
				return _layerThickness;
			} 
			set
			{
				SetValue( v =>  _layerThickness = v, _layerThickness, value,  "LayerThickness");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLogical? @IsVentilated 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _isVentilated;
				((IPersistEntity)this).Activate(false);
				return _isVentilated;
			} 
			set
			{
				SetValue( v =>  _isVentilated = v, _isVentilated, value,  "IsVentilated");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcText? @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Category 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _category;
				((IPersistEntity)this).Activate(false);
				return _category;
			} 
			set
			{
				SetValue( v =>  _category = v, _category, value,  "Category");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcNormalisedRatioMeasure? @Priority 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _priority;
				((IPersistEntity)this).Activate(false);
				return _priority;
			} 
			set
			{
				SetValue( v =>  _priority = v, _priority, value,  "Priority");
			} 
		}	
		#endregion



		#region Inverse attributes
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, -1, -1)]
		public IfcMaterialLayerSet @ToMaterialLayerSet 
		{ 
			get 
			{
				return Model.Instances.FirstOrDefault<IfcMaterialLayerSet>(e => e.MaterialLayers != null &&  e.MaterialLayers.Contains(this));
			} 
		}
		#endregion


		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_material = (IfcMaterial)(value.EntityVal);
					return;
				case 1: 
					_layerThickness = value.RealVal;
					return;
				case 2: 
					_isVentilated = value.BooleanVal;
					return;
				case 3: 
					_name = value.StringVal;
					return;
				case 4: 
					_description = value.StringVal;
					return;
				case 5: 
					_category = value.StringVal;
					return;
				case 6: 
					_priority = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcMaterialLayer other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialLayer
            var root = (@IfcMaterialLayer)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialLayer left, @IfcMaterialLayer right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialLayer left, @IfcMaterialLayer right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterialLayer x, @IfcMaterialLayer y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterialLayer obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}