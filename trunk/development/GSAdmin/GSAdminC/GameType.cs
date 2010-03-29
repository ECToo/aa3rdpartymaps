#region Using directives
using System;
#endregion

namespace GameServerInfo
{
	/// <summary>
	/// Gameserver types
	/// </summary>
	public enum GameType
	{
	
		#region Quake3
		/// <summary>
		/// Quake 3
		/// </summary>
		Quake3 = GameProtocol.Quake3,
		/// <summary>
		/// Call of Duty
		/// </summary>
		CallOfDuty = GameProtocol.Quake3,
		/// <summary>
		/// Star Wars Jedi Knight: Jedi Academy
		/// </summary>
		JediKnightJediAcademy = GameProtocol.Quake3,
		/// <summary>
		/// Call of Duty: United Offensive
		/// </summary>
		CallOfDutyUnitedOffensive = GameProtocol.Quake3,
		/// <summary>
		/// Star Trek: Voyager - Elite Force
		/// </summary>
		StarTrekVoyagerEliteForce = GameProtocol.Quake3,
		/// <summary>
		/// Star Trek: Voyager - Elite Force 2
		/// </summary>
		StarTrekVoyagerEliteForce2 = GameProtocol.Quake3,
		/// <summary>
		/// Soldier of Fortune 2
		/// </summary>
		SoldierOfFortune2 = GameProtocol.Quake3,
		/// <summary>
		/// Return to Castle Wolfenstein
		/// </summary>
		ReturnToCastleWolfenstein = GameProtocol.Quake3,
		/// <summary>
		/// Wolfenstein: Enemy Territory
		/// </summary>
		WolfensteinEnemyTerritory = GameProtocol.Quake3,
		/// <summary>
		/// Star Wars Jedi Knight 2: Jedi Outcast
		/// </summary>
		JediKnightJediOutcast = GameProtocol.Quake3,
		/// <summary>
		/// Soldier of Fortune
		/// </summary>
		SoldierOfFortune = GameProtocol.Quake3,
		/// <summary>
		/// Daikatana
		/// </summary>
		Daikatana = GameProtocol.Quake3,
		#endregion
	
		/// <summary>
		/// Not listed game
		/// </summary>
		Unkown = GameProtocol.None
	}

	/// <summary>
	/// Gameserver protocol
	/// </summary>
	public enum GameProtocol
	{
		
		/// <summary>
		/// Quake3 and Q3-Mods
		/// </summary>
		Quake3,
		/// <summary>
		/// Unkown
		/// </summary>
		None
	}
}
