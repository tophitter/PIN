﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyGameServer.Controllers.Character {
	[ControllerID(Enums.GSS.Controllers.Character_CombatController)]
	internal class CombatController : Base {
		public override void Init( INetworkClient client, IPlayer player, IInstance inst ) {
			// TODO: Implement
			
		}

		[MessageID((byte)Enums.GSS.Character.Commands.FireInputIgnored)]
		public void FireInputIgnored( INetworkClient client, IPlayer player, ulong EntityID, Packets.GamePacket packet ) {
			// TODO: Implement
		}

		[MessageID((byte)Enums.GSS.Character.Commands.UseScope)]
		public void UseScope( INetworkClient client, IPlayer player, ulong EntityID, Packets.GamePacket packet ) {
			// TODO: Implement
		}
	}
}