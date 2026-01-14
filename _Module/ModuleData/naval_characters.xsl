<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="yes"/>
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.nord_1haxe_blunt' or @id='Item.nord_1hsword_blunt' or @id='Item.nord_sword_2_t3' or @id='Item.nord_sword_1_t4' or @id='Item.nord_sword_2_t4' or @id='Item.nord_sword_3_t4']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.wooden_sword_t1'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.nord_2haxe_blunt' or @id='Item.nord_battle_axe_7_t2' or @id='Item.nord_battle_axe_4_t3' or @id='Item.nord_twohanded_axe_1_t3' or @id='Item.nord_battle_axe_3_t4' or @id='Item.nord_twohanded_axe_6_t4' or @id='Item.nord_twohanded_axe_5_t4' or @id='Item.nord_twohanded_axe_2_t4']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.peasant_maul_t1_2'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.nord_spear_1_t2' or @id='Item.nord_spear_2_t3' or @id='Item.nord_spear_1_t3' or @id='Item.nord_spear_atgeir_1_t4']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.practice_spear_t1'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.nord_atgeir_polearm_blunt' or @id='Item.nord_polearm_blunt']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.blunt_polearm'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.nord_javelin_blunt' or @id='Item.northern_javelin_1_t2' or @id='Item.nord_spear_javelin_1_t3']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.blunt_javelin'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.nord_throwing_axe_blunt' or @id='Item.nord_throwing_axe_1_t2' or @id='Item.nord_throwing_axe_1_t3' or @id='Item.nord_throwing_axe_2_t4' or @id='Item.nord_throwing_axe_1_t4']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.sling_stoneammo_nonlethal'"/>
		</xsl:attribute>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster[equipment/@id='Item.nord_throwing_axe_blunt' or equipment/@id='Item.nord_throwing_axe_1_t2' or equipment/@id='Item.nord_throwing_axe_1_t3' or equipment/@id='Item.nord_throwing_axe_2_t4' or equipment/@id='Item.nord_throwing_axe_1_t4']">
		<xsl:copy>
			<xsl:apply-templates/>
			<equipment slot="Item3" id="Item.sling_wool"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="NPCCharacter[contains(@id,'tournament_template') or contains(@id,'weapon_practice')]/Equipments/EquipmentRoster/equipment[@id='Item.default_arrows' or @id='Item.tournament_arrows']/@id">
		<xsl:attribute name="id">
			<xsl:value-of select="'Item.blunt_arrows'"/>
		</xsl:attribute>
	</xsl:template>
</xsl:stylesheet>
