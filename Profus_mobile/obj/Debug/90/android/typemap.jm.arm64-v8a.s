<<<<<<< HEAD
	/* Data Hash: 6813EFBD14B3A6B9 */
=======
	/* Data Hash: 0C4676ED6B70034E */
>>>>>>> parent of 33b27d6... 1.1.1
	.arch	armv8-a
	.file	"typemap.jm.inc"

	/* Mapping header */
	.section	.data.jm_typemap,"aw",@progbits
	.type	jm_typemap_header, @object
	.p2align	2
	.global	jm_typemap_header
jm_typemap_header:
	/* version */
	.word	1
	/* entry-count */
<<<<<<< HEAD
	.word	1041
=======
	.word	1039
>>>>>>> parent of 33b27d6... 1.1.1
	/* entry-length */
	.word	262
	/* value-offset */
	.word	117
	.size	jm_typemap_header, 16

	/* Mapping data */
	.type	jm_typemap, @object
	.global	jm_typemap
jm_typemap:
<<<<<<< HEAD
	.size	jm_typemap, 272743
=======
	.size	jm_typemap, 272219
>>>>>>> parent of 33b27d6... 1.1.1
	.include	"typemap.jm.inc"
