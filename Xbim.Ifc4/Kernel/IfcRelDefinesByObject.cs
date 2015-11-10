// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.UtilityResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelDefinesByObject
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelDefinesByObject : IIfcRelDefines
	{
		IEnumerable<IIfcObject> @RelatedObjects { get; }
		IIfcObject @RelatingObject { get; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IFCRELDEFINESBYOBJECT", 932)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelDefinesByObject : IfcRelDefines, IInstantiableEntity, IIfcRelDefinesByObject, IEqualityComparer<@IfcRelDefinesByObject>, IEquatable<@IfcRelDefinesByObject>
	{
		#region IIfcRelDefinesByObject explicit implementation
		IEnumerable<IIfcObject> IIfcRelDefinesByObject.RelatedObjects { get { return @RelatedObjects; } }	
		IIfcObject IIfcRelDefinesByObject.RelatingObject { get { return @RelatingObject; } }	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelDefinesByObject(IModel model) : base(model) 		{ 
			Model = model; 
			_relatedObjects = new ItemSet<IfcObject>( this, 0 );
		}

		#region Explicit attribute fields
		private ItemSet<IfcObject> _relatedObjects;
		private IfcObject _relatingObject;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, 1, -1)]
		public ItemSet<IfcObject> @RelatedObjects 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatedObjects;
				((IPersistEntity)this).Activate(false);
				return _relatedObjects;
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcObject @RelatingObject 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingObject;
				((IPersistEntity)this).Activate(false);
				return _relatingObject;
			} 
			set
			{
				SetValue( v =>  _relatingObject = v, _relatingObject, value,  "RelatingObject");
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
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					if (_relatedObjects == null) _relatedObjects = new ItemSet<IfcObject>( this );
					_relatedObjects.InternalAdd((IfcObject)value.EntityVal);
					return;
				case 5: 
					_relatingObject = (IfcObject)(value.EntityVal);
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
        public bool Equals(@IfcRelDefinesByObject other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelDefinesByObject
            var root = (@IfcRelDefinesByObject)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelDefinesByObject left, @IfcRelDefinesByObject right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelDefinesByObject left, @IfcRelDefinesByObject right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcRelDefinesByObject x, @IfcRelDefinesByObject y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcRelDefinesByObject obj)
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