# 📘 Pi Rush – Level Design Document  

# 1. Tutorial

## 1.1 Level Goals
The Tutorial level teaches the player:

- How to sling the character from one circle to another  
- The basic rule: **“always jump to the next digit of Pi”**  
- How mistakes are punished and how feedback works  
- How hints and lives work in a forgiving environment  

Goal: finish the first 4 digits of Pi (3.141) without pressure.

## 1.2 Puzzle Structure & Active Mechanics

### Pi Range:  
Digits from 3 → 3.141 (4 correct jumps total).

### Puzzle Types

#### Single Correct vs Single Wrong (2 circles)
At each jump:  
- 1 circle = correct next digit of Pi  
- 1 circle = random wrong digit  

Mistake effect: the character falls back to the start of the current digit, not the whole level.

#### Hint-Guided Jump
During the first two jumps: Text bubble appears: *“Always jump to the next digit of Pi”*

### Active Mechanics
- Sling movement (drag → release to jump)  
- Basic collision with circles  
- Immediate feedback: Correct: “Perfect!” popup + soft sound. Wrong: fall animation + red flash on wrong digit  


## 1.3 Environmental Layout
- 2 circles per step (1 correct, 1 distractor)  
- Simple vertical or diagonal line  
- Short distances, easy aiming  
- Static background (light grid or sky)



## 1.4 Resources & Limitations
- Lives: infinite  
- Hints: 1 automatic hint for each of first 2 jumps  
- Time pressure: none  
- Failure condition: none, mistakes only reset the current jump  

## 1.5 Difficulty
The Tutorial is intentionally very easy:

- Only 2 choices
- Only 4 digits
- guiding text  
- No time limit  
- Minimal punishment  

Focus: learning rules and controls, not the challenge himself.


# 2. Level 1 – First Challenge

## 2.1 Level Goals
Level 1 introduces real gameplay:

- Recall a longer Pi sequence  
- Choose between more options  
- Handle light time pressure  

Goal: complete first 10 digits of Pi (3.141592653) with a feeling of progression.


## 2.2 Puzzle Structure & Active Mechanics

### Pi Range:
Digits from 3 to digit 10 of Pi.

### Puzzle Types

#### Static Triple Choice (3 circles)
Each step shows:
- 1 correct digit  
- 2 wrong digits  

Mistake effect:  
Fall back to start of level (digit 3), but the game shows the correct number.


#### Soft Time Limit (Digit Fade)
- After 2–3 seconds, digits fade slightly  
- Encourages quick decisions  
- Not a hard penalty



### Active Mechanics
- Sling jump (slightly longer distances than Tutorial)  
- Static circles  
- Basic UI showing: current digit index and best score  

## 2.3 Environmental Layout
- 3 circles per step
- Background: slight parallax for a “vertical climb” feel



## 2.4 Resources & Limitations
- Lives: 3 for the whole level  
- Hints: 2 manual hints  
- Time pressure: soft fade after 2–3 seconds  
- No instant fail for waiting  



## 2.5 Difficulty
Level 1 = easy/medium

- 10 digits → more memory  
- 3 choices → higher challenge  
- Soft time pressure  
- Restarting level feels meaningful but not harsh  

Teaches memorization + consistent aiming without frustration.



# 3. Level 2 – Pattern Mastery

## 3.1 Level Goals
Level 2 increases challenge with:

- Longer Pi sequence  
- Moving circles  
- Stronger time pressure  
- More punishing mistakes  

Goal: reach digit 20 in one run.


## 3.2 Puzzle Structure & Active Mechanics

### Pi Range:  
First 20 digits of Pi.

### Puzzle Types

#### Moving Triple Choice
- 3 circles move slowly (vertical or horizontal)  
- Player must consider digit correctness + timing  


#### *imed Fade + Partial Disappearance
- After 3s: digits fade  
- After 4s: two digits vanish completely  
- The correct digit stays visible slightly longer  


#### checkpoint Puzzles
At special milestones, e.g., digits 10 and 15:
- Correct jump sets a new respawn point  
- These jumps are slightly harder


### Active Mechanics
- Longer sling jumps  
- Moving circles  
- Feedback on mistakes: Character falls and screen briefly shows the correct digit in big text  

## 3.3 Environmental Layout
- 3–4 circles per step  
- Vertical climbing path, some angled shots  
- Background: scrolling starfield or math pattern


## 3.4 Resources & Limitations
- Lives: 3  
- Checkpoints: at digits 10 and 15  
- Hints: 1 manual hint  
- Time pressure: Fade at 3s and two digits vanish completely at 5s  

## 3.5 Difficulty
Level 2 = medium–hard

- 20 digits  
- Moving targets  
- Digits disappearing  
- Few hints  
- Real timeouts  

Balanced combination of memory, timing, aiming, with checkpoints to reduce frustration.

# 4. Level 3 – Advanced Memory Rush

## 4.1 Level Goals
Level 3 is the true challenge for committed players:

- Very fast decisions  
- More distractors  
- Complex movement patterns  

Goal: reach digit 30 (or more in endless mode).

## 4.2 Puzzle Structure & Active Mechanics

### Pi Range:
First 30 digits.

### Puzzle Types

#### Fast Moving Multi-Choice (4 circles)
- 1 correct  
- 3 wrong  
- Circles move on different patterns  

Some distractors reuse recent digits to confuse memory.


#### “Memory Only” Puzzles
- Digits appear for 1.5 second then fade  
- Player must rely purely on memory of position


#### Chain Challenge Segments
- 5–7 jumps with no checkpoint  
- Mistake resets the entire chain, not just one jump


### Active Mechanics
- More sensitive sling physics  
- Faster movement  
- Strong combo feedback (sounds, glow trails)


## 4.3 Environmental Layout
- Mostly 4 circles, sometimes 3  
- Wide spreads, long diagonal shots  
- Slight overlapping trajectories requiring precise timing  
- Background: faster parallax, intense colors

## 4.4 Resources & Limitations
- Lives: 2 total  
- Hints: none free  
- Purchased hints pause gameplay only briefly  
- Time pressure: Fade after 1.5 seconds and auto-fail at 4 seconds


## 4.5 Difficulty Rationale
Level 3 = hard

- 30 digits  
- 4 choices  
- Fast-moving targets  
- Memory-only puzzles  
- Strict time limits  
- Limited lives and hints  

Designed as a real skill test for Pi masters and precision players.



