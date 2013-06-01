<!DOCTYPE html>
<html>
  <head>
    <title>iGame</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="css/bootstrap.min.css" rel="stylesheet" media="screen">
	<!--<link href="css/game.css" rel="stylesheet" media="screen">-->
	<style type="text/css">
		.btn-game {
			margin-top:10px;
			margin-bottom:10px;
		}
	</style>
  </head>
  <body>

  <div class="container">
	  <div class="row">
			<div class="title text-center span6 offset3">
				<h4>iGame</h4>
				A port of Game by <a href="http://dr3v.com/">Nelson Gatlin</a>.
			</div>
			<div class="buttons span6 offset3">
				<div class="row">
					<button class="btn btn-mini btn-game span2" id="1"></button>
					<button class="btn btn-mini btn-game span2" id="2"></button>
					<button class="btn btn-mini btn-game span2" id="3"></button>
				</div>
				<div class="row">
					<button class="btn btn-mini btn-game span2" id="4"></button>
					<button class="btn btn-mini btn-game span2" id="5"></button>
					<button class="btn btn-mini btn-game span2" id="6"></button>
				</div>
				<div class="row">
					<button class="btn btn-mini btn-game span2" id="7"></button>
					<button class="btn btn-mini btn-game span2" id="8"></button>
					<button class="btn btn-mini btn-game span2" id="9"></button>
				</div>
			</div>
			<div class="text-center span6 offset3">
				<h6>Score: <span id="score">0</span></h6>
				<h6>Clicks: <span id="clicks">0</span></h6>
				<h6>High Score: <span id="highscore">0</span></h6>
			</div>
		</div>
	</div>
		
	<script src="http://code.jquery.com/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>
	<script>
		var cw = $('.btn-game').width(),
		    score = 0,
		    clicks = 0,
		    highscore = 0,
		    level = 0;
		function toggle(theId) {
			if ( theId >= 1 && theId <= 9 ) {
				var theBtn = $('#' + theId);
				if ( theBtn.hasClass('btn-danger') ) {
					theBtn.removeClass('btn-danger');
				} else {
					theBtn.addClass('btn-danger');
				}	
			}
		}
		$('.btn-game')
			.css({'height':cw+'px'})
			.click(function(){
				//do the toggles
				clicks++;
				theId = parseInt($(this).attr("id"));
				toggle(theId);						//toggle myself
				toggle(theId-3); toggle(theId+3);	//toggle above and below me
				if ( theId%3 != 1 ) { //if I'm not the leftmost
					toggle(theId-1); //toggle to the left of me
				}
				if ( theId%3 != 0 ) { //if I'm not the rightmost
					toggle(theId+1); //toggle to the right of me
				}
				
				//check if the user won this round
				if ( $('.btn-danger').length >= 9 ) {
					score = (++level/clicks)*100;
					if(level >= 10) endGame();
					else alert("You did it! Only " + (10 - level) + " more " + ((10 - level == 1) ? "level" : "levels") + " to go!");
					$('.btn-danger').removeClass('btn-danger'); //reset field to white
					//set the field based on the winning click
					switch ( theId ) {
						case 1:
							$('#2').addClass('btn-danger');
							$('#4').addClass('btn-danger');
							$('#8').addClass('btn-danger');
							break;
						case 2:
							$('#5').addClass('btn-danger');
							$('#8').addClass('btn-danger');
							break;
						case 3:
						case 6:
							$('#1').addClass('btn-danger');
							$('#6').addClass('btn-danger');
							$('#9').addClass('btn-danger');
							break;
						case 4:
							$('#2').addClass('btn-danger');
							$('#5').addClass('btn-danger');
							$('#7').addClass('btn-danger');
							break;
						case 5:
							$('#2').addClass('btn-danger');
							$('#7').addClass('btn-danger');
							$('#9').addClass('btn-danger');
							break;
						case 7:
							$('#1').addClass('btn-danger');
							$('#3').addClass('btn-danger');
							$('#8').addClass('btn-danger');
							break;
						case 8:
							$('#2').addClass('btn-danger');
							$('#3').addClass('btn-danger');
							$('#5').addClass('btn-danger');
							$('#8').addClass('btn-danger');
							break;
						case 9:
							$('#2').addClass('btn-danger');
							$('#5').addClass('btn-danger');
							$('#7').addClass('btn-danger');
							$('#9').addClass('btn-danger');
							break;
					}
				}
				$('#clicks').text(clicks);
				$('#score').text(score);
				$('#highscore').text(highscore);
			})
		;
		function endGame(){
			highscore = (highscore >= score) ? highscore : score;
			alert((highscore == score) ? "High score!" : "Well done!"
				+ " Your score was: " + score + ".");
			score = 0;
			clicks = 0;
			level = 0;
		}
	</script>

  </body>
</html>