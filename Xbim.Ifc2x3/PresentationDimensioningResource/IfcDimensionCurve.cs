// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.PresentationDefinitionResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationDimensioningResource;
//## Custom using statements
//##


namespace Xbim.Ifc2x3.PresentationDimensioningResource
{
	[ExpressType("IfcDimensionCurve", 742)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcDimensionCurve : IfcAnnotationCurveOccurrence, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcDimensionCurve>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcDimensionCurve(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}




		#region Inverse attributes
		[InverseProperty("AnnotatedCurve")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 2 }, 6)]
		public IEnumerable<IfcTerminatorSymbol> @AnnotatedBySymbols 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTerminatorSymbol>(e => Equals(e.AnnotatedCurve), "AnnotatedCurve", this);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcDimensionCurve other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Item != null)
					yield return @Item;
				foreach(var entity in @Styles)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@Item != null)
					yield return @Item;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}