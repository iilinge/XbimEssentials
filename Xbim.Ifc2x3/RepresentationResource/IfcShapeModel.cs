// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.RepresentationResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.RepresentationResource
{
	[ExpressType("IfcShapeModel", 89)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcShapeModel : IfcRepresentation, IEquatable<@IfcShapeModel>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcShapeModel(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}




		#region Inverse attributes
		[InverseProperty("ShapeRepresentations")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 8)]
		public IEnumerable<IfcShapeAspect> @OfShapeAspect 
		{ 
			get 
			{
				return Model.Instances.Where<IfcShapeAspect>(e => e.ShapeRepresentations != null &&  e.ShapeRepresentations.Contains(this), "ShapeRepresentations", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcShapeModel other)
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