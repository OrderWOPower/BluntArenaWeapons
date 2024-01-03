<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="yes"/>
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="CraftingTemplate[@id='TwoHandedPolearm']/UsablePieces">
		<xsl:copy>
			<xsl:apply-templates/>
			<UsablePiece piece_id="blunt_polearm_head" />
		</xsl:copy>
	</xsl:template>
	<xsl:template match="CraftingTemplate[@id='Javelin']/WeaponDescriptions">
		<xsl:copy>
			<xsl:apply-templates/>
			<WeaponDescription id="Javelin_Blunt" />
		</xsl:copy>
	</xsl:template>
	<xsl:template match="CraftingTemplate[@id='Javelin']/UsablePieces">
		<xsl:copy>
			<xsl:apply-templates/>
			<UsablePiece piece_id="spear_blade_34" />
			<UsablePiece piece_id="spear_pommel_8" />
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>