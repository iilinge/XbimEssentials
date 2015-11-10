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
using Xbim.Ifc4.ProfileResource;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCompositeProfileDef
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCompositeProfileDef : IIfcProfileDef
	{
		IEnumerable<IIfcProfileDef> @Profiles { get; }
		IfcLabel? @Label { get; }
	
	}
}

namespace Xbim.Ifc4.ProfileResource
{
	[ExpressType("IFCCOMPOSITEPROFILEDEF", 503)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCompositeProfileDef : IfcProfileDef, IInstantiableEntity, IIfcCompositeProfileDef, IEqualityComparer<@IfcCompositeProfileDef>, IEquatable<@IfcCompositeProfileDef>
	{
		#region IIfcCompositeProfileDef explicit implementation
		IEnumerable<IIfcProfileDef> IIfcCompositeProfileDef.Profiles { get { return @Profiles; } }	
		IfcLabel? IIfcCompositeProfileDef.Label { get { return @Label; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCompositeProfileDef(IModel model) : base(model) 		{ 
			Model = model; 
			_profiles = new ItemSet<IfcProfileDef>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcProfileDef> _profiles;
		private IfcLabel? _label;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 2, -1)]
		public ItemSet<IfcProfileDef> @Profiles 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _profiles;
				((IPersistEntity)this).Activate(false);
				return _profiles;
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcLabel? @Label 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _label;
				((IPersistEntity)this).Activate(false);
				return _label;
			} 
			set
			{
				SetValue( v =>  _label = v, _label, value,  "Label");
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					if (_profiles == null) _profiles = new ItemSet<IfcProfileDef>( this );
					_profiles.InternalAdd((IfcProfileDef)value.EntityVal);
					return;
				case 3: 
					_label = value.StringVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public  override string WhereRule() 
		{
            throw new System.NotImplementedException();
		/*InvariantProfileType:	InvariantProfileType : SIZEOF(QUERY(temp <* Profiles | temp.ProfileType <> Profiles[1].ProfileType)) = 0;*/
		/*NoRecursion:	NoRecursion : SIZEOF(QUERY(temp <* Profiles | 'IFC4.IFCCOMPOSITEPROFILEDEF' IN TYPEOF(temp))) = 0;*/
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCompositeProfileDef other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCompositeProfileDef
            var root = (@IfcCompositeProfileDef)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCompositeProfileDef left, @IfcCompositeProfileDef right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCompositeProfileDef left, @IfcCompositeProfileDef right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcCompositeProfileDef x, @IfcCompositeProfileDef y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcCompositeProfileDef obj)
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