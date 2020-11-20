<<<<<<< HEAD
	/* Data Hash: 0CEF0344EBD5F3E3 */
=======
	/* Data Hash: DD92583CC5D7650C */
>>>>>>> parent of 33b27d6... 1.1.1
	.file	"typemap.mj.inc"

	/* Mapping header */
	.section	.data.mj_typemap,"aw",@progbits
	.type	mj_typemap_header, @object
	.p2align	2
	.global	mj_typemap_header
mj_typemap_header:
	/* version */
	.long	1
	/* entry-count */
<<<<<<< HEAD
	.long	1154
=======
	.long	1152
>>>>>>> parent of 33b27d6... 1.1.1
	/* entry-length */
	.long	262
	/* value-offset */
	.long	145
	.size	mj_typemap_header, 16

	/* Mapping data */
	.type	mj_typemap, @object
	.global	mj_typemap
mj_typemap:
<<<<<<< HEAD
	.size	mj_typemap, 302349
=======
	.size	mj_typemap, 301825
>>>>>>> parent of 33b27d6... 1.1.1
	.include	"typemap.mj.inc"
