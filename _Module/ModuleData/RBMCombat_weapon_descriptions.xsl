<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output omit-xml-declaration="yes"/>
	<xsl:template match="@*|node()">
		<xsl:copy>
			<xsl:apply-templates select="@*|node()"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="WeaponDescription[@id='TwoHandedPolearm_Couchable']/AvailablePieces">
		<xsl:copy>
			<xsl:apply-templates/>
			<AvailablePiece id="spear_blade_34"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="WeaponDescription[@id='TwoHandedPolearm']/AvailablePieces">
		<xsl:copy>
			<xsl:apply-templates/>
			<AvailablePiece id="blunt_polearm_head"/>
		</xsl:copy>
	</xsl:template>
	<xsl:template match="WeaponDescription[@id='Javelin' or @id='OneHandedPolearm_JavelinAlternative']/AvailablePieces">
		<xsl:copy>
			<xsl:apply-templates/>
			<AvailablePiece id="spear_blade_34"/>
			<AvailablePiece id="spear_pommel_8"/>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>