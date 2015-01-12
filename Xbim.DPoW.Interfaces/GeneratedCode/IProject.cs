﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// The DPoW project that this Plan Of Work is delivering part of
/// </summary>
public interface IProject 
{
	/// <summary>
	/// The short code use to reference the project within DPoW
	/// </summary>
	string ProjectCode { get; }

	LinearUnits LinearUnits { get;set; }

	AreaUnits AreaUnits { get;set; }

	/// <summary>
	/// FFull name of the project
	/// </summary>
	string ProjectName { get;set; }

	VolumeUnits VolumeUnits { get;set; }

	/// <summary>
	/// URI of the project linking it back to DPoW
	/// </summary>
	string ProjectURI { get;set; }

	string ProjectDescription { get;set; }

	CurrencyUnits CurrencyUnits { get;set; }

	IProjectStage CurrentProjectStage { get;set; }

}

