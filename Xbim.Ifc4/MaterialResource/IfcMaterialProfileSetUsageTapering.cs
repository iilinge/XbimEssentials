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
    /// Readonly interface for IfcMaterialProfileSetUsageTapering
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcMaterialProfileSetUsageTapering : IIfcMaterialProfileSetUsage
	{
		IIfcMaterialProfileSet @ForProfileEndSet { get; }
		IfcCardinalPointReference? @CardinalEndPoint { get; }
	
	}
}

namespace Xbim.Ifc4.MaterialResource
{
	[ExpressType("IFCMATERIALPROFILESETUSAGETAPERING", 755)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcMaterialProfileSetUsageTapering : IfcMaterialProfileSetUsage, IInstantiableEntity, IIfcMaterialProfileSetUsageTapering, IEqualityComparer<@IfcMaterialProfileSetUsageTapering>, IEquatable<@IfcMaterialProfileSetUsageTapering>
	{
		#region IIfcMaterialProfileSetUsageTapering explicit implementation
		IIfcMaterialProfileSet IIfcMaterialProfileSetUsageTapering.ForProfileEndSet { get { return @ForProfileEndSet; } }	
		IfcCardinalPointReference? IIfcMaterialProfileSetUsageTapering.CardinalEndPoint { get { return @CardinalEndPoint; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcMaterialProfileSetUsageTapering(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcMaterialProfileSet _forProfileEndSet;
		private IfcCardinalPointReference? _cardinalEndPoint;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcMaterialProfileSet @ForProfileEndSet 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _forProfileEndSet;
				((IPersistEntity)this).Activate(false);
				return _forProfileEndSet;
			} 
			set
			{
				SetValue( v =>  _forProfileEndSet = v, _forProfileEndSet, value,  "ForProfileEndSet");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcCardinalPointReference? @CardinalEndPoint 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _cardinalEndPoint;
				((IPersistEntity)this).Activate(false);
				return _cardinalEndPoint;
			} 
			set
			{
				SetValue( v =>  _cardinalEndPoint = v, _cardinalEndPoint, value,  "CardinalEndPoint");
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 3: 
					_forProfileEndSet = (IfcMaterialProfileSet)(value.EntityVal);
					return;
				case 4: 
					_cardinalEndPoint = value.IntegerVal;
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
        public bool Equals(@IfcMaterialProfileSetUsageTapering other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcMaterialProfileSetUsageTapering
            var root = (@IfcMaterialProfileSetUsageTapering)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcMaterialProfileSetUsageTapering left, @IfcMaterialProfileSetUsageTapering right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcMaterialProfileSetUsageTapering left, @IfcMaterialProfileSetUsageTapering right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcMaterialProfileSetUsageTapering x, @IfcMaterialProfileSetUsageTapering y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcMaterialProfileSetUsageTapering obj)
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