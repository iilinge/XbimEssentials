// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.StructuralLoadResource
{
	public partial class @IfcStructuralLoadSingleForce : IIfcStructuralLoadSingleForce
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadSingleForce), 2)]
		Ifc4.MeasureResource.IfcForceMeasure? IIfcStructuralLoadSingleForce.ForceX 
		{ 
			get
			{
				if (!ForceX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcForceMeasure(ForceX.Value);
			} 
			set
			{
				ForceX = value.HasValue ? 
					new MeasureResource.IfcForceMeasure(value.Value) :  
					 new MeasureResource.IfcForceMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadSingleForce), 3)]
		Ifc4.MeasureResource.IfcForceMeasure? IIfcStructuralLoadSingleForce.ForceY 
		{ 
			get
			{
				if (!ForceY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcForceMeasure(ForceY.Value);
			} 
			set
			{
				ForceY = value.HasValue ? 
					new MeasureResource.IfcForceMeasure(value.Value) :  
					 new MeasureResource.IfcForceMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadSingleForce), 4)]
		Ifc4.MeasureResource.IfcForceMeasure? IIfcStructuralLoadSingleForce.ForceZ 
		{ 
			get
			{
				if (!ForceZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcForceMeasure(ForceZ.Value);
			} 
			set
			{
				ForceZ = value.HasValue ? 
					new MeasureResource.IfcForceMeasure(value.Value) :  
					 new MeasureResource.IfcForceMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadSingleForce), 5)]
		Ifc4.MeasureResource.IfcTorqueMeasure? IIfcStructuralLoadSingleForce.MomentX 
		{ 
			get
			{
				if (!MomentX.HasValue) return null;
				return new Ifc4.MeasureResource.IfcTorqueMeasure(MomentX.Value);
			} 
			set
			{
				MomentX = value.HasValue ? 
					new MeasureResource.IfcTorqueMeasure(value.Value) :  
					 new MeasureResource.IfcTorqueMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadSingleForce), 6)]
		Ifc4.MeasureResource.IfcTorqueMeasure? IIfcStructuralLoadSingleForce.MomentY 
		{ 
			get
			{
				if (!MomentY.HasValue) return null;
				return new Ifc4.MeasureResource.IfcTorqueMeasure(MomentY.Value);
			} 
			set
			{
				MomentY = value.HasValue ? 
					new MeasureResource.IfcTorqueMeasure(value.Value) :  
					 new MeasureResource.IfcTorqueMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadSingleForce), 7)]
		Ifc4.MeasureResource.IfcTorqueMeasure? IIfcStructuralLoadSingleForce.MomentZ 
		{ 
			get
			{
				if (!MomentZ.HasValue) return null;
				return new Ifc4.MeasureResource.IfcTorqueMeasure(MomentZ.Value);
			} 
			set
			{
				MomentZ = value.HasValue ? 
					new MeasureResource.IfcTorqueMeasure(value.Value) :  
					 new MeasureResource.IfcTorqueMeasure?() ;
				
			}
		}
	//## Custom code
	//##
	}
}