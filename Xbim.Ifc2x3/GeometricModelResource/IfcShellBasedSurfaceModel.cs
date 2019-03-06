// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.GeometryResource;
using Xbim.Ifc2x3.TopologyResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometricModelResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.GeometricModelResource
{
	[ExpressType("IfcShellBasedSurfaceModel", 235)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcShellBasedSurfaceModel : IfcGeometricRepresentationItem, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcShellBasedSurfaceModel>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcShellBasedSurfaceModel(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_sbsmBoundary = new ItemSet<IfcShell>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcShell> _sbsmBoundary;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 3)]
		public IItemSet<IfcShell> @SbsmBoundary 
		{ 
			get 
			{
				if(_activated) return _sbsmBoundary;
				Activate();
				return _sbsmBoundary;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, null, null, 0)]
		public IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
			    return 3;
			    //##
			}
		}

		#endregion


		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_sbsmBoundary.InternalAdd((IfcShell)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcShellBasedSurfaceModel other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @SbsmBoundary)
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