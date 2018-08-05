<?php
/**
 * Single-movies template file.
 */
get_header();

$layout_type = get_post_meta(get_the_id(), 'layouts', true);

if(empty($layout_type)) {
	$layout_type = get_option('vh_layout_style') ? get_option('vh_layout_style') : 'full';
}

$img       = wp_get_attachment_image_src( get_post_thumbnail_id(), 'offer-image-large' );
$span_size = 'vc_col-sm-9';
?>
<div class="page-<?php echo LAYOUT; ?> page-wrapper">
	<div class="clearfix"></div>
	<div class="page_info">
		<?php
		if ( get_post_type( $post ) == 'post' ) {
			echo '<h1 class="blog_title">' . __( 'Blog', 'vh' ) . '</h1>' .
			vh_breadcrumbs();
		} elseif ( !is_front_page() && !is_home() ) { ?>
			<div class="page-title">
				<?php echo  the_title( '<h1>', '</h1>' );?>
			</div>
			<?php echo vh_breadcrumbs(); ?>
		<?php } ?>
	</div>
	<div class="content vc_row wpb_row vc_row-fluid">
		<?php
		wp_reset_postdata();
		if (LAYOUT == 'sidebar-left' && $_GET['event_id'] == null ) {
		?>
		<div class="vc_col-sm-3 <?php echo LAYOUT; ?>">
			<div class="sidebar-inner">
			<?php
				global $vh_is_in_sidebar;
				$vh_is_in_sidebar = true;
				generated_dynamic_sidebar();
			?>
			</div>
		</div><!--end of sidebars-->
		<?php } ?>
		<div class="<?php echo LAYOUT; ?>-pull <?php echo (LAYOUT != 'sidebar-no' && isset($_GET['event_id']) == null ) ? 'vc_col-sm-9' : 'vc_col-sm-12'; echo ( isset($_GET['event_id']) != null ) ? ' seat_row' : '';?>">
			<div class="main-content">
				<div class="main-inner">
					<?php if ( isset($_GET['event_id']) != 0 ) {
						echo do_shortcode('[showseats id='.$_GET['event_id'].']');
					} else { ?>
						<div class="vc_row wpb_row vc_row-fluid">
							<?php
							if ( have_posts() ) {
								while ( have_posts() ) {
									the_post();
									get_template_part( 'content-movies', 'single' ); 
									if ( get_post_type( $post ) == 'movies' ) { ?>
										<div class="clearfix"></div>
										<div class="comments_container vc_col-sm-12">
											<div class="clearfix"></div>
											<?php comments_template( '', true ); ?>
										</div>
										<?php
									}
								}
							} else {
								echo '
									<h2>Nothing Found</h2>
									<p>Sorry, it appears there is no content in this section.</p>';
							}
							?>
						</div>
					<?php } ?>
													
				</div>
			</div>
		</div>
		<?php
		if ( LAYOUT == 'sidebar-right' && isset($_GET['event_id']) == null ) {
		?>
		<div class="vc_col-sm-3 pull-right <?php echo LAYOUT; ?>">
			<div class="sidebar-inner">
			<?php
				global $vh_is_in_sidebar;
				$vh_is_in_sidebar = true;
				generated_dynamic_sidebar();
			?>
			<div class="clearfix"></div>
			</div>
		</div><!--end of span3-->
		<?php } ?>
		<?php $vh_is_in_sidebar = false; ?>
		<div class="clearfix"></div>
	</div><!--end of content-->
	<div class="clearfix"></div>
</div><!--end of page-wrapper-->
<?php get_footer();