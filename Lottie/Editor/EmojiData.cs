﻿using System.Collections.Generic;
using Unity.Plastic.Newtonsoft.Json;
using UnityEngine;

namespace Lottie.Editor
{
    internal struct EmojiData
    {
        public EmojiCategory[] data;
    }
        
    internal struct EmojiCategory
    {
        public string category;
        public Emoji[] emojis;
    }
        
    internal struct Emoji
    {
        public string name;
        public string code;
    }
    
    internal class EmojiGetter
    {
        private readonly EmojiData _emojiData;
        
        public EmojiGetter()
        {
            const string json = "{\"data\":[{\"category\":\"Smileys and emotions\",\"emojis\":[{\"name\":\"Smile\",\"code\":\"1f600\"},{\"name\":\"Smile-with-big-eyes\",\"code\":\"1f603\"},{\"name\":\"Grin\",\"code\":\"1f604\"},{\"name\":\"Grinning\",\"code\":\"1f601\"},{\"name\":\"Laughing\",\"code\":\"1f606\"},{\"name\":\"Grin-sweat\",\"code\":\"1f605\"},{\"name\":\"Joy\",\"code\":\"1f602\"},{\"name\":\"Rofl\",\"code\":\"1f923\"},{\"name\":\"Loudly-crying\",\"code\":\"1f62d\"},{\"name\":\"Wink\",\"code\":\"1f609\"},{\"name\":\"Kissing\",\"code\":\"1f617\"},{\"name\":\"Kissing-smiling-eyes\",\"code\":\"1f619\"},{\"name\":\"Kissing-closed-eyes\",\"code\":\"1f61a\"},{\"name\":\"Kissing-heart\",\"code\":\"1f618\"},{\"name\":\"Heart-face\",\"code\":\"1f970\"},{\"name\":\"Heart-eyes\",\"code\":\"1f60d\"},{\"name\":\"Star-struck\",\"code\":\"1f929\"},{\"name\":\"Partying-face\",\"code\":\"1f973\"},{\"name\":\"Melting\",\"code\":\"1fae0\"},{\"name\":\"Upside-down-face\",\"code\":\"1f643\"},{\"name\":\"Slightly-happy\",\"code\":\"1f642\"},{\"name\":\"Happy-cry\",\"code\":\"1f972\"},{\"name\":\"Holding-back-tears\",\"code\":\"1f979\"},{\"name\":\"Blush\",\"code\":\"1f60a\"},{\"name\":\"Warm-smile\",\"code\":\"263a_fe0f\"},{\"name\":\"Relieved\",\"code\":\"1f60c\"},{\"name\":\"Smirk\",\"code\":\"1f60f\"},{\"name\":\"Drool\",\"code\":\"1f924\"},{\"name\":\"Yum\",\"code\":\"1f60b\"},{\"name\":\"Stuck-out-tongue\",\"code\":\"1f61b\"},{\"name\":\"Squinting-tongue\",\"code\":\"1f61d\"},{\"name\":\"Winky-tongue\",\"code\":\"1f61c\"},{\"name\":\"Zany-face\",\"code\":\"1f92a\"},{\"name\":\"Woozy\",\"code\":\"1f974\"},{\"name\":\"Pensive\",\"code\":\"1f614\"},{\"name\":\"Pleading\",\"code\":\"1f97a\"},{\"name\":\"Grimacing\",\"code\":\"1f62c\"},{\"name\":\"Expressionless\",\"code\":\"1f611\"},{\"name\":\"Neutral-face\",\"code\":\"1f610\"},{\"name\":\"Mouth-none\",\"code\":\"1f636\"},{\"name\":\"Face-in-clouds\",\"code\":\"1f636_200d_1f32b_fe0f\"},{\"name\":\"Dotted-line-face\",\"code\":\"1fae5\"},{\"name\":\"Zipper-face\",\"code\":\"1f910\"},{\"name\":\"Salute\",\"code\":\"1fae1\"},{\"name\":\"Thinking-face\",\"code\":\"1f914\"},{\"name\":\"Shushing-face\",\"code\":\"1f92b\"},{\"name\":\"Hand-over-mouth\",\"code\":\"1fae2\"},{\"name\":\"Smiling-eyes-with-hand-over-mouth\",\"code\":\"1f92d\"},{\"name\":\"Yawn\",\"code\":\"1f971\"},{\"name\":\"Hug-face\",\"code\":\"1f917\"},{\"name\":\"Peeking\",\"code\":\"1fae3\"},{\"name\":\"Screaming\",\"code\":\"1f631\"},{\"name\":\"Raised-eyebrow\",\"code\":\"1f928\"},{\"name\":\"Monocle\",\"code\":\"1f9d0\"},{\"name\":\"Unamused\",\"code\":\"1f612\"},{\"name\":\"Rolling-eyes\",\"code\":\"1f644\"},{\"name\":\"Exhale\",\"code\":\"1f62e_200d_1f4a8\"},{\"name\":\"Triumph\",\"code\":\"1f624\"},{\"name\":\"Angry\",\"code\":\"1f620\"},{\"name\":\"Rage\",\"code\":\"1f621\"},{\"name\":\"Cursing\",\"code\":\"1f92c\"},{\"name\":\"Sad\",\"code\":\"1f61e\"},{\"name\":\"Sweat\",\"code\":\"1f613\"},{\"name\":\"Worried\",\"code\":\"1f61f\"},{\"name\":\"Concerned\",\"code\":\"1f625\"},{\"name\":\"Cry\",\"code\":\"1f622\"},{\"name\":\"Big-frown\",\"code\":\"2639_fe0f\"},{\"name\":\"Frown\",\"code\":\"1f641\"},{\"name\":\"Diagonal-mouth\",\"code\":\"1fae4\"},{\"name\":\"Slightly-frowning\",\"code\":\"1f615\"},{\"name\":\"Anxious-with-sweat\",\"code\":\"1f630\"},{\"name\":\"Scared\",\"code\":\"1f628\"},{\"name\":\"Anguished\",\"code\":\"1f627\"},{\"name\":\"Gasp\",\"code\":\"1f626\"},{\"name\":\"Mouth-open\",\"code\":\"1f62e\"},{\"name\":\"Surprised\",\"code\":\"1f62f\"},{\"name\":\"Astonished\",\"code\":\"1f632\"},{\"name\":\"Flushed\",\"code\":\"1f633\"},{\"name\":\"Mind-blown\",\"code\":\"1f92f\"},{\"name\":\"Scrunched-mouth\",\"code\":\"1f616\"},{\"name\":\"Scrunched-eyes\",\"code\":\"1f623\"},{\"name\":\"Weary\",\"code\":\"1f629\"},{\"name\":\"Distraught\",\"code\":\"1f62b\"},{\"name\":\"X-eyes\",\"code\":\"1f635\"},{\"name\":\"Dizzy-face\",\"code\":\"1f635_200d_1f4ab\"},{\"name\":\"Shaking-face\",\"code\":\"1fae8\"},{\"name\":\"Cold-face\",\"code\":\"1f976\"},{\"name\":\"Hot-face\",\"code\":\"1f975\"},{\"name\":\"Sick\",\"code\":\"1f922\"},{\"name\":\"Vomit\",\"code\":\"1f92e\"},{\"name\":\"Sleep\",\"code\":\"1f634\"},{\"name\":\"Sleepy\",\"code\":\"1f62a\"},{\"name\":\"Sneeze\",\"code\":\"1f927\"},{\"name\":\"Thermometer-face\",\"code\":\"1f912\"},{\"name\":\"Bandage-face\",\"code\":\"1f915\"},{\"name\":\"Mask\",\"code\":\"1f637\"},{\"name\":\"Liar\",\"code\":\"1f925\"},{\"name\":\"Halo\",\"code\":\"1f607\"},{\"name\":\"Cowboy\",\"code\":\"1f920\"},{\"name\":\"Money-face\",\"code\":\"1f911\"},{\"name\":\"Nerd-face\",\"code\":\"1f913\"},{\"name\":\"Sunglasses-face\",\"code\":\"1f60e\"},{\"name\":\"Disguise\",\"code\":\"1f978\"},{\"name\":\"Clown\",\"code\":\"1f921\"},{\"name\":\"Imp-smile\",\"code\":\"1f608\"},{\"name\":\"Imp-frown\",\"code\":\"1f47f\"},{\"name\":\"Ghost\",\"code\":\"1f47b\"},{\"name\":\"Skull\",\"code\":\"1f480\"},{\"name\":\"Jack-o-lantern\",\"code\":\"1f383\"},{\"name\":\"Poop\",\"code\":\"1f4a9\"},{\"name\":\"Robot\",\"code\":\"1f916\"},{\"name\":\"Alien\",\"code\":\"1f47d\"},{\"name\":\"Sun-with-face\",\"code\":\"1f31e\"},{\"name\":\"Moon-face-first-quarter\",\"code\":\"1f31b\"},{\"name\":\"Moon-face-last-quarter\",\"code\":\"1f31c\"},{\"name\":\"See-no-evil-monkey\",\"code\":\"1f648\"},{\"name\":\"Hear-no-evil-monkey\",\"code\":\"1f649\"},{\"name\":\"Speak-no-evil-monkey\",\"code\":\"1f64a\"},{\"name\":\"Smiley-cat\",\"code\":\"1f63a\"},{\"name\":\"Smile-cat\",\"code\":\"1f638\"},{\"name\":\"Joy-cat\",\"code\":\"1f639\"},{\"name\":\"Heart-eyes-cat\",\"code\":\"1f63b\"},{\"name\":\"Smirk-cat\",\"code\":\"1f63c\"},{\"name\":\"Kissing-cat\",\"code\":\"1f63d\"},{\"name\":\"Scream-cat\",\"code\":\"1f640\"},{\"name\":\"Crying-cat-face\",\"code\":\"1f63f\"},{\"name\":\"Pouting-cat\",\"code\":\"1f63e\"},{\"name\":\"Glowing-star\",\"code\":\"1f31f\"},{\"name\":\"Sparkles\",\"code\":\"2728\"},{\"name\":\"Collision\",\"code\":\"1f4a5\"},{\"name\":\"Fire\",\"code\":\"1f525\"},{\"name\":\"100\",\"code\":\"1f4af\"},{\"name\":\"Party-popper\",\"code\":\"1f389\"},{\"name\":\"Red-heart\",\"code\":\"2764_fe0f\"},{\"name\":\"Orange-heart\",\"code\":\"1f9e1\"},{\"name\":\"Yellow-heart\",\"code\":\"1f49b\"},{\"name\":\"Green-heart\",\"code\":\"1f49a\"},{\"name\":\"Light-blue-heart\",\"code\":\"1fa75\"},{\"name\":\"Blue-heart\",\"code\":\"1f499\"},{\"name\":\"Purple-heart\",\"code\":\"1f49c\"},{\"name\":\"Brown-heart\",\"code\":\"1f90e\"},{\"name\":\"Black-heart\",\"code\":\"1f5a4\"},{\"name\":\"Grey-heart\",\"code\":\"1fa76\"},{\"name\":\"White-heart\",\"code\":\"1f90d\"},{\"name\":\"Pink-heart\",\"code\":\"1fa77\"},{\"name\":\"Cupid\",\"code\":\"1f498\"},{\"name\":\"Gift-heart\",\"code\":\"1f49d\"},{\"name\":\"Sparkling-heart\",\"code\":\"1f496\"},{\"name\":\"Heart-grow\",\"code\":\"1f497\"},{\"name\":\"Beating-heart\",\"code\":\"1f493\"},{\"name\":\"Revolving-hearts\",\"code\":\"1f49e\"},{\"name\":\"Two-hearts\",\"code\":\"1f495\"},{\"name\":\"Love-letter\",\"code\":\"1f48c\"},{\"name\":\"Heart-box\",\"code\":\"1f49f\"},{\"name\":\"Heart-exclamation-point\",\"code\":\"2763_fe0f\"},{\"name\":\"Bandaged-heart\",\"code\":\"2764_fe0f_200d_1fa79\"},{\"name\":\"Broken-heart\",\"code\":\"1f494\"},{\"name\":\"Fire-heart\",\"code\":\"2764_fe0f_200d_1f525\"},{\"name\":\"Kiss\",\"code\":\"1f48b\"},{\"name\":\"Footprints\",\"code\":\"1f463\"},{\"name\":\"Anatomical-heart\",\"code\":\"1fac0\"},{\"name\":\"Blood\",\"code\":\"1fa78\"},{\"name\":\"Microbe\",\"code\":\"1f9a0\"},{\"name\":\"Eyes\",\"code\":\"1f440\"},{\"name\":\"Eye\",\"code\":\"1f441_fe0f\"},{\"name\":\"Biting-lip\",\"code\":\"1fae6\"},{\"name\":\"Leg-mechanical\",\"code\":\"1f9bf\"},{\"name\":\"Arm-mechanical\",\"code\":\"1f9be\"},{\"name\":\"Muscle\",\"code\":\"1f4aa\"},{\"name\":\"Muscle\",\"code\":\"1f4aa_1f3fb\"},{\"name\":\"Muscle\",\"code\":\"1f4aa_1f3fc\"},{\"name\":\"Muscle\",\"code\":\"1f4aa_1f3fd\"},{\"name\":\"Muscle\",\"code\":\"1f4aa_1f3fe\"},{\"name\":\"Muscle\",\"code\":\"1f4aa_1f3ff\"},{\"name\":\"Clap\",\"code\":\"1f44f\"},{\"name\":\"Clap\",\"code\":\"1f44f_1f3fb\"},{\"name\":\"Clap\",\"code\":\"1f44f_1f3fc\"},{\"name\":\"Clap\",\"code\":\"1f44f_1f3fd\"},{\"name\":\"Clap\",\"code\":\"1f44f_1f3fe\"},{\"name\":\"Clap\",\"code\":\"1f44f_1f3ff\"},{\"name\":\"Thumbs-up\",\"code\":\"1f44d\"},{\"name\":\"Thumbs-up\",\"code\":\"1f44d_1f3fb\"},{\"name\":\"Thumbs-up\",\"code\":\"1f44d_1f3fc\"},{\"name\":\"Thumbs-up\",\"code\":\"1f44d_1f3fd\"},{\"name\":\"Thumbs-up\",\"code\":\"1f44d_1f3fe\"},{\"name\":\"Thumbs-up\",\"code\":\"1f44d_1f3ff\"},{\"name\":\"Thumbs-down\",\"code\":\"1f44e\"},{\"name\":\"Thumbs-down\",\"code\":\"1f44e_1f3fb\"},{\"name\":\"Thumbs-down\",\"code\":\"1f44e_1f3fc\"},{\"name\":\"Thumbs-down\",\"code\":\"1f44e_1f3fd\"},{\"name\":\"Thumbs-down\",\"code\":\"1f44e_1f3fe\"},{\"name\":\"Thumbs-down\",\"code\":\"1f44e_1f3ff\"},{\"name\":\"Raising-hands\",\"code\":\"1f64c\"},{\"name\":\"Raising-hands\",\"code\":\"1f64c_1f3fb\"},{\"name\":\"Raising-hands\",\"code\":\"1f64c_1f3fc\"},{\"name\":\"Raising-hands\",\"code\":\"1f64c_1f3fd\"},{\"name\":\"Raising-hands\",\"code\":\"1f64c_1f3fe\"},{\"name\":\"Raising-hands\",\"code\":\"1f64c_1f3ff\"},{\"name\":\"Wave\",\"code\":\"1f44b\"},{\"name\":\"Wave\",\"code\":\"1f44b_1f3fb\"},{\"name\":\"Wave\",\"code\":\"1f44b_1f3fc\"},{\"name\":\"Wave\",\"code\":\"1f44b_1f3fd\"},{\"name\":\"Wave\",\"code\":\"1f44b_1f3fe\"},{\"name\":\"Wave\",\"code\":\"1f44b_1f3ff\"},{\"name\":\"Victory\",\"code\":\"270c_fe0f\"},{\"name\":\"Victory\",\"code\":\"270c_1f3fb\"},{\"name\":\"Victory\",\"code\":\"270c_1f3fc\"},{\"name\":\"Victory\",\"code\":\"270c_1f3fd\"},{\"name\":\"Victory\",\"code\":\"270c_1f3fe\"},{\"name\":\"Victory\",\"code\":\"270c_1f3ff\"},{\"name\":\"Crossed-fingers\",\"code\":\"1f91e\"},{\"name\":\"Crossed-fingers\",\"code\":\"1f91e_1f3fb\"},{\"name\":\"Crossed-fingers\",\"code\":\"1f91e_1f3fc\"},{\"name\":\"Crossed-fingers\",\"code\":\"1f91e_1f3fd\"},{\"name\":\"Crossed-fingers\",\"code\":\"1f91e_1f3fe\"},{\"name\":\"Crossed-fingers\",\"code\":\"1f91e_1f3ff\"},{\"name\":\"Index-finger\",\"code\":\"261d_fe0f\"},{\"name\":\"Index-finger\",\"code\":\"261d_1f3fb\"},{\"name\":\"Index-finger\",\"code\":\"261d_1f3fc\"},{\"name\":\"Index-finger\",\"code\":\"261d_1f3fd\"},{\"name\":\"Index-finger\",\"code\":\"261d_1f3fe\"},{\"name\":\"Index-finger\",\"code\":\"261d_1f3ff\"},{\"name\":\"Folded-hands\",\"code\":\"1f64f\"},{\"name\":\"Folded-hands\",\"code\":\"1f64f_1f3fb\"},{\"name\":\"Folded-hands\",\"code\":\"1f64f_1f3fc\"},{\"name\":\"Folded-hands\",\"code\":\"1f64f_1f3fd\"},{\"name\":\"Folded-hands\",\"code\":\"1f64f_1f3fe\"},{\"name\":\"Folded-hands\",\"code\":\"1f64f_1f3ff\"}]},{\"category\":\"People\",\"emojis\":[{\"name\":\"Dancer-woman\",\"code\":\"1f483\"},{\"name\":\"Dancer-woman\",\"code\":\"1f483_1f3fb\"},{\"name\":\"Dancer-woman\",\"code\":\"1f483_1f3fc\"},{\"name\":\"Dancer-woman\",\"code\":\"1f483_1f3fd\"},{\"name\":\"Dancer-woman\",\"code\":\"1f483_1f3fe\"},{\"name\":\"Dancer-woman\",\"code\":\"1f483_1f3ff\"}]},{\"category\":\"Animals and nature\",\"emojis\":[{\"name\":\"Rose\",\"code\":\"1f339\"},{\"name\":\"Wilted-flower\",\"code\":\"1f940\"},{\"name\":\"Fallen-leaf\",\"code\":\"1f342\"},{\"name\":\"Plant\",\"code\":\"1f331\"},{\"name\":\"Leaves\",\"code\":\"1f343\"},{\"name\":\"Luck\",\"code\":\"1f340\"},{\"name\":\"Snowflake\",\"code\":\"2744_fe0f\"},{\"name\":\"Volcano\",\"code\":\"1f30b\"},{\"name\":\"Sunrise\",\"code\":\"1f305\"},{\"name\":\"Sunrise-over-mountains\",\"code\":\"1f304\"},{\"name\":\"Rainbow\",\"code\":\"1f308\"},{\"name\":\"Bubbles\",\"code\":\"1fae7\"},{\"name\":\"Ocean\",\"code\":\"1f30a\"},{\"name\":\"Wind-face\",\"code\":\"1f32c_fe0f\"},{\"name\":\"Tornado\",\"code\":\"1f32a_fe0f\"},{\"name\":\"Electricity\",\"code\":\"26a1\"},{\"name\":\"Droplet\",\"code\":\"1f4a7\"},{\"name\":\"Rain-cloud\",\"code\":\"1f327_fe0f\"},{\"name\":\"Cloud-with-lightning\",\"code\":\"1f329_fe0f\"},{\"name\":\"Dizzy\",\"code\":\"1f4ab\"},{\"name\":\"Comet\",\"code\":\"2604_fe0f\"},{\"name\":\"Globe-showing-europe-africa\",\"code\":\"1f30d\"},{\"name\":\"Globe-showing-americas\",\"code\":\"1f30e\"},{\"name\":\"Globe-showing-asia-australia\",\"code\":\"1f30f\"},{\"name\":\"Cow-face\",\"code\":\"1f42e\"},{\"name\":\"Unicorn\",\"code\":\"1f984\"},{\"name\":\"Lizard\",\"code\":\"1f98e\"},{\"name\":\"Dragon\",\"code\":\"1f409\"},{\"name\":\"T-rex\",\"code\":\"1f996\"},{\"name\":\"Dinosaur\",\"code\":\"1f995\"},{\"name\":\"Turtle\",\"code\":\"1f422\"},{\"name\":\"Crocodile\",\"code\":\"1f40a\"},{\"name\":\"Snake\",\"code\":\"1f40d\"},{\"name\":\"Frog\",\"code\":\"1f438\"},{\"name\":\"Rabbit\",\"code\":\"1f407\"},{\"name\":\"Rat\",\"code\":\"1f400\"},{\"name\":\"Poodle\",\"code\":\"1f429\"},{\"name\":\"Dog\",\"code\":\"1f415\"},{\"name\":\"Guide-dog\",\"code\":\"1f9ae\"},{\"name\":\"Service-dog\",\"code\":\"1f415_200d_1f9ba\"},{\"name\":\"Pig\",\"code\":\"1f416\"},{\"name\":\"Racehorse\",\"code\":\"1f40e\"},{\"name\":\"Donkey\",\"code\":\"1facf\"},{\"name\":\"Ox\",\"code\":\"1f402\"},{\"name\":\"Goat\",\"code\":\"1f410\"},{\"name\":\"Kangaroo\",\"code\":\"1f998\"},{\"name\":\"Tiger\",\"code\":\"1f405\"},{\"name\":\"Monkey\",\"code\":\"1f412\"},{\"name\":\"Gorilla\",\"code\":\"1f98d\"},{\"name\":\"Orangutan\",\"code\":\"1f9a7\"},{\"name\":\"Chipmunk\",\"code\":\"1f43f_fe0f\"},{\"name\":\"Otter\",\"code\":\"1f9a6\"},{\"name\":\"Bat\",\"code\":\"1f987\"},{\"name\":\"Bird\",\"code\":\"1f426\"},{\"name\":\"Black-bird\",\"code\":\"1f426_200d_2b1b\"},{\"name\":\"Rooster\",\"code\":\"1f413\"},{\"name\":\"Hatching-chick\",\"code\":\"1f423\"},{\"name\":\"Baby-chick\",\"code\":\"1f424\"},{\"name\":\"Hatched-chick\",\"code\":\"1f425\"},{\"name\":\"Eagle\",\"code\":\"1f985\"},{\"name\":\"Peace\",\"code\":\"1f54a_fe0f\"},{\"name\":\"Goose\",\"code\":\"1fabf\"},{\"name\":\"Peacock\",\"code\":\"1f99a\"},{\"name\":\"Seal\",\"code\":\"1f9ad\"},{\"name\":\"Shark\",\"code\":\"1f988\"},{\"name\":\"Dolphin\",\"code\":\"1f42c\"},{\"name\":\"Whale\",\"code\":\"1f433\"},{\"name\":\"Blowfish\",\"code\":\"1f421\"},{\"name\":\"Crab\",\"code\":\"1f980\"},{\"name\":\"Octopus\",\"code\":\"1f419\"},{\"name\":\"Jellyfish\",\"code\":\"1fabc\"},{\"name\":\"Spider\",\"code\":\"1f577_fe0f\"},{\"name\":\"Snail\",\"code\":\"1f40c\"},{\"name\":\"Ant\",\"code\":\"1f41c\"},{\"name\":\"Mosquito\",\"code\":\"1f99f\"},{\"name\":\"Cockroach\",\"code\":\"1fab3\"},{\"name\":\"Fly\",\"code\":\"1fab0\"},{\"name\":\"Bee\",\"code\":\"1f41d\"},{\"name\":\"Lady-bug\",\"code\":\"1f41e\"},{\"name\":\"Butterfly\",\"code\":\"1f98b\"},{\"name\":\"Bug\",\"code\":\"1f41b\"},{\"name\":\"Worm\",\"code\":\"1fab1\"},{\"name\":\"Paw Prints\",\"code\":\"1f43e\"}]},{\"category\":\"Food and drink\",\"emojis\":[{\"name\":\"Tomato\",\"code\":\"1f345\"},{\"name\":\"Cooking\",\"code\":\"1f373\"},{\"name\":\"Spaghetti\",\"code\":\"1f35d\"},{\"name\":\"Steaming-bowl\",\"code\":\"1f35c\"},{\"name\":\"Popcorn\",\"code\":\"1f37f\"},{\"name\":\"Hot-beverage\",\"code\":\"2615\"},{\"name\":\"Clinking-beer-mugs\",\"code\":\"1f37b\"},{\"name\":\"Clinking-glasses\",\"code\":\"1f942\"},{\"name\":\"Bottle-with-popping-cork\",\"code\":\"1f37e\"},{\"name\":\"Wine-glass\",\"code\":\"1f377\"},{\"name\":\"Tropical-drink\",\"code\":\"1f379\"}]},{\"category\":\"Travel and places\",\"emojis\":[{\"name\":\"Construction\",\"code\":\"1f6a7\"},{\"name\":\"Police-car-light\",\"code\":\"1f6a8\"},{\"name\":\"Bicycle\",\"code\":\"1f6b2\"},{\"name\":\"Flying-saucer\",\"code\":\"1f6f8\"},{\"name\":\"Rocket\",\"code\":\"1f680\"},{\"name\":\"Airplane-departure\",\"code\":\"1f6eb\"},{\"name\":\"Airplane-arrival\",\"code\":\"1f6ec\"},{\"name\":\"Roller-coaster\",\"code\":\"1f3a2\"},{\"name\":\"Camping\",\"code\":\"1f3d5_fe0f\"}]},{\"category\":\"Activities and events\",\"emojis\":[{\"name\":\"Confetti-ball\",\"code\":\"1f38a\"},{\"name\":\"Balloon\",\"code\":\"1f388\"},{\"name\":\"Birthday-cake\",\"code\":\"1f382\"},{\"name\":\"Wrapped-gift\",\"code\":\"1f381\"},{\"name\":\"Fireworks\",\"code\":\"1f386\"},{\"name\":\"Piñata\",\"code\":\"1fa85\"},{\"name\":\"Mirror-ball\",\"code\":\"1faa9\"},{\"name\":\"Soccer-ball\",\"code\":\"26bd\"},{\"name\":\"Baseball\",\"code\":\"26be\"},{\"name\":\"Softball\",\"code\":\"1f94e\"},{\"name\":\"Tennis\",\"code\":\"1f3be\"},{\"name\":\"Badminton\",\"code\":\"1f3f8\"},{\"name\":\"Lacrosse\",\"code\":\"1f94d\"},{\"name\":\"Cricket-game\",\"code\":\"1f3cf\"},{\"name\":\"Field-hockey\",\"code\":\"1f3d1\"},{\"name\":\"Ice-hockey\",\"code\":\"1f3d2\"},{\"name\":\"Direct-hit\",\"code\":\"1f3af\"},{\"name\":\"Flying-disc\",\"code\":\"1f94f\"},{\"name\":\"Boomerang\",\"code\":\"1fa83\"},{\"name\":\"Kite\",\"code\":\"1fa81\"},{\"name\":\"Ping-pong\",\"code\":\"1f3d3\"},{\"name\":\"Bowling\",\"code\":\"1f3b3\"},{\"name\":\"Die\",\"code\":\"1f3b2\"},{\"name\":\"Slot-machine\",\"code\":\"1f3b0\"},{\"name\":\"Camera-flash\",\"code\":\"1f4f8\"},{\"name\":\"Violin\",\"code\":\"1f3bb\"},{\"name\":\"Drum\",\"code\":\"1f941\"},{\"name\":\"Maracas\",\"code\":\"1fa87\"}]},{\"category\":\"Objects\",\"emojis\":[{\"name\":\"Battery-full\",\"code\":\"1f50b\"},{\"name\":\"Battery-low\",\"code\":\"1faab\"},{\"name\":\"Money-with-wings\",\"code\":\"1f4b8\"},{\"name\":\"Balance-scale\",\"code\":\"2696_fe0f\"},{\"name\":\"Light-bulb\",\"code\":\"1f4a1\"},{\"name\":\"Graduation-cap\",\"code\":\"1f393\"},{\"name\":\"Umbrella\",\"code\":\"2602_fe0f\"},{\"name\":\"Gem-stone\",\"code\":\"1f48e\"},{\"name\":\"Gear\",\"code\":\"2699_fe0f\"},{\"name\":\"Pencil\",\"code\":\"270f_fe0f\"},{\"name\":\"Alarm-clock\",\"code\":\"23f0\"},{\"name\":\"Bellhop-bell\",\"code\":\"1f6ce_fe0f\"},{\"name\":\"Bell\",\"code\":\"1f514\"},{\"name\":\"Crystal-ball\",\"code\":\"1f52e\"}]},{\"category\":\"Symbols\",\"emojis\":[{\"name\":\"Aries\",\"code\":\"2648\"},{\"name\":\"Taurus\",\"code\":\"2649\"},{\"name\":\"Gemini\",\"code\":\"264a\"},{\"name\":\"Cancer\",\"code\":\"264b\"},{\"name\":\"Leo\",\"code\":\"264c\"},{\"name\":\"Virgo\",\"code\":\"264d\"},{\"name\":\"Libra\",\"code\":\"264e\"},{\"name\":\"Scorpio\",\"code\":\"264f\"},{\"name\":\"Sagittarius\",\"code\":\"2650\"},{\"name\":\"Capricorn\",\"code\":\"2651\"},{\"name\":\"Aquarius\",\"code\":\"2652\"},{\"name\":\"Pisces\",\"code\":\"2653\"},{\"name\":\"Ophiuchus\",\"code\":\"26ce\"},{\"name\":\"Exclamation\",\"code\":\"2757\"},{\"name\":\"Question\",\"code\":\"2753\"},{\"name\":\"Exclamation-question-mark\",\"code\":\"2049_fe0f\"},{\"name\":\"Exclamation-double\",\"code\":\"203c_fe0f\"},{\"name\":\"Cross-mark\",\"code\":\"274c\"},{\"name\":\"Sos\",\"code\":\"1f198\"},{\"name\":\"Phone-off\",\"code\":\"1f4f4\"},{\"name\":\"Check-mark\",\"code\":\"2705\"},{\"name\":\"New\",\"code\":\"1f195\"},{\"name\":\"Free\",\"code\":\"1f193\"},{\"name\":\"Up!\",\"code\":\"1f199\"},{\"name\":\"Cool\",\"code\":\"1f192\"},{\"name\":\"Litter\",\"code\":\"1f6ae\"},{\"name\":\"Musical-notes\",\"code\":\"1f3b6\"},{\"name\":\"Plus-sign\",\"code\":\"2795\"}]},{\"category\":\"Flags\",\"emojis\":[{\"name\":\"Chequered-flag\",\"code\":\"1f3c1\"},{\"name\":\"Triangular-flag\",\"code\":\"1f6a9\"},{\"name\":\"Black-flag\",\"code\":\"1f3f4\"},{\"name\":\"White-flag\",\"code\":\"1f3f3_fe0f\"}]}]}";
            _emojiData = JsonConvert.DeserializeObject<EmojiData>(json);
        }

        public List<Emoji> GetAllEmojis()
        {
            var emojis = new List<Emoji>();
            foreach (var category in _emojiData.data)
            {
                emojis.AddRange(category.emojis);
            }

            return emojis;
        }
    }
}