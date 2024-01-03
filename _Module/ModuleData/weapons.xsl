<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="yes"/>
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="CraftedItem[@id='practice_spear_t1']/Pieces/Piece[@Type='Handle']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'spear_handle_20'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="CraftedItem[@id='practice_spear_t1']/Pieces/Piece[@Type='Handle']">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
			<xsl:attribute name="scale_factor">
				<xsl:value-of select="181"/>
			</xsl:attribute>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="CraftedItem[@id='practice_spear_t1']/Pieces/Piece[@Type='Pommel']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'spear_pommel_3'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="Items">
		<xsl:copy>
			<xsl:apply-templates/>
			<CraftedItem id="blunt_polearm" name="Blunt Polearm" is_merchandise="false" crafting_template="TwoHandedPolearm">
				<Pieces>
					<Piece id="blunt_polearm_head" Type="Blade" scale_factor="100" />
					<Piece id="spear_handle_26" Type="Handle" scale_factor="90" />
					<Piece id="spear_pommel_11" Type="Pommel" scale_factor="100" />
				</Pieces>
			</CraftedItem>
			<CraftedItem id="blunt_javelin" name="Blunt Javelin" is_merchandise="false" crafting_template="Javelin" item_modifier_group="spear_dart_throwing">
				<Pieces>
					<Piece id="spear_blade_34" Type="Blade" scale_factor="100" />
					<Piece id="spear_handle_11" Type="Handle" scale_factor="230" />
					<Piece id="spear_pommel_8" Type="Pommel" scale_factor="100" />
				</Pieces>
			</CraftedItem>
			<Item id="throwing_stone_enhanced" name="Enhanced Stones" is_merchandise="false" body_name="bo_throwing_stone" holster_body_name="bo_axe_short" holster_mesh="stone_holster" holster_mesh_with_weapon="stone_holster" mesh="throwing_stone" value="2" weight="0.3" appearance="0.1" Type="Thrown" item_holsters="throwing_stone:throwing_stone_2">
				<ItemComponent>
					<Weapon weapon_class="Stone" ammo_class="Stone" stack_amount="10" physics_material="missile" accuracy="45" thrust_speed="102" speed_rating="102" missile_speed="30" weapon_length="10" thrust_damage="150" item_usage="stone" rotation="100,30,20" passby_sound_code="" rotation_speed="0, -3.0, 0">
						<WeaponFlags RangedWeapon="true" Consumable="true" AutoReload="true" UnloadWhenSheathed="true" UseHandAsThrowBase="true"/>
					</Weapon>
				</ItemComponent>
				<Flags />
			</Item>
			<Item id="blunt_bolts" name="Blunt Bolts" is_merchandise="false" body_name="bo_capsule_arrow" holster_body_name="bo_axe_short" mesh="bolt_bl_b_arena" holster_mesh="bolt_bl_b_quiver" holster_mesh_with_weapon="bolt_bl_b_quiver" flying_mesh="bolt_bl_flying" weight="0.09" appearance="1" Type="Bolts" item_holsters="quiver_bolts:quiver_bolts_2:quiver_back_middle:quiver_back_top">
				<ItemComponent>
					<Weapon weapon_class="Bolt" stack_amount="30" thrust_speed="0" thrust_damage="150" thrust_damage_type="Blunt" speed_rating="0" missile_speed="65" weapon_length="37" item_usage="" passby_sound_code="event:/mission/combat/missile/passby" rotation="180, 0, 0" physics_material="missile" sticking_position="0,-0.37,0" sticking_rotation="90,0,0" center_of_mass="0,0,0" item_modifier_group="bolt">
						<WeaponFlags AttachAmmoToVisual="true" Consumable="true" />
					</Weapon>
				</ItemComponent>
				<Flags ForceAttachOffHandPrimaryItemBone="true" />
			</Item>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="Item[@id='blunt_arrows']">
		<Item id="blunt_arrows" name="Blunt Arrows" is_merchandise="false" body_name="bo_capsule_arrow" holster_body_name="bo_axe_short" mesh="arrow_bl_arena" holster_mesh="arrow_bl_a_quiver" holster_mesh_with_weapon="arrow_bl_a_quiver" weight="0.09" flying_mesh="arrow_bl_flying" appearance="1" Type="Arrows" item_holsters="quiver_back_middle:quiver_bolts_2:quiver_bolts" holster_position_shift="0.0,0.0,0.15">
			<ItemComponent>
				<Weapon weapon_class="Arrow" stack_amount="30" thrust_speed="0" speed_rating="0" physics_material="missile" missile_speed="90" weapon_length="97" thrust_damage="100" thrust_damage_type="Blunt" item_usage="arrow_right" passby_sound_code="event:/mission/combat/missile/passby" rotation="0, -80, 25" sticking_position="0,-0.97,0" sticking_rotation="90,0,0" center_of_mass="0,0,0" item_modifier_group="arrow">
					<WeaponFlags Consumable="true" />
				</Weapon>
			</ItemComponent>
			<Flags />
		</Item>
	</xsl:template>
</xsl:stylesheet>