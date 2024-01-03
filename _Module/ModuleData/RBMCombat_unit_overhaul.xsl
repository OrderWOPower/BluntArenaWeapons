<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="yes"/>
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.empire_mace_5_t5' or @id='Item.aserai_mace_4_t4' or @id='Item.empire_sword_1_t2' or @id='Item.empire_sword_3_t3' or @id='Item.empire_sword_5_t4' or @id='Item.light_mace_t3' or @id='Item.empire_mace_1_t2' or @id='Item.empire_mace_2_t4' or @id='Item.vlandia_sword_1_t2' or @id='Item.vlandia_sword_2_t3' or @id='Item.vlandia_sword_3_t4' or @id='Item.aserai_sword_2_t2' or @id='Item.aserai_sword_3_t3' or @id='Item.aserai_sword_5_t4' or @id='Item.aserai_mace_1_t2' or @id='Item.aserai_mace_3_t3' or @id='Item.aserai_mace_4_t4' or @id='Item.sturgia_axe_2_t2' or @id='Item.sturgia_axe_3_t3' or @id='Item.sturgia_axe_4_t4' or @id='Item.battania_sword_1_t2' or @id='Item.battania_sword_2_t3' or @id='Item.battania_sword_4_t4' or @id='Item.battania_mace_1_t2' or @id='Item.khuzait_sword_1_t2' or @id='Item.khuzait_sword_2_t3' or @id='Item.khuzait_sword_5_t4']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.wooden_sword_t1'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.aserai_2haxe_3_t5' or @id='Item.battania_2hsword_4_t4' or @id='Item.battania_polearm_1_t5' or @id='Item.bearded_axe_t3' or @id='Item.hooked_axe_t4' or @id='Item.vlandia_2haxe_1_t4' or @id='Item.aserai_2haxe_2_t4' or @id='Item.sturgia_2haxe_1_t4' or @id='Item.battania_2haxe_1_t2']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.peasant_maul_t1_2'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.empire_lance_3_t5' or @id='Item.vlandia_lance_3_t5' or @id='Item.imperial_spear_t2' or @id='Item.western_spear_2_t2' or @id='Item.western_spear_3_t3' or @id='Item.western_spear_4_t4' or @id='Item.northern_spear_1_t2' or @id='Item.northern_spear_3_t4' or @id='Item.eastern_spear_1_t2' or @id='Item.eastern_spear_2_t3' or @id='Item.eastern_spear_3_t3' or @id='Item.eastern_spear_4_t4']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.practice_spear_t1'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.billhook_polearm_t2' or @id='Item.khuzait_polearm_1_t4']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.blunt_polearm'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.generic_javelin_1_t3' or @id='Item.western_javelin_1_t2' or @id='Item.northern_javelin_1_t2' or @id='Item.eastern_javelin_1_t2' or @id='Item.eastern_javelin_2_t3']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.blunt_javelin'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.desert_throwing_knife' or @id='Item.highland_throwing_axe_1_t2']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.throwing_stone_enhanced'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.bodkin_arrows_a' or @id='Item.default_arrows' or @id='Item.tournament_arrows']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.blunt_arrows'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.bolt_a' or @id='Item.bolt_c' or @id='Item.tournament_bolts']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.blunt_bolts'"/>
		</xsl:attribute>
	</xsl:template>
</xsl:stylesheet>