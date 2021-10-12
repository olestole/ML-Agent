# ML-Agents

First test of Unity's ML-Agents Toolkit. Create a simple model for navigating from a random position to a target given the positions of both the agent and the target.

## Getting Started

### Dependencies

* Unity (2019.4 or later)
* Python (3.6.1 or higher)
* ML-Agents (Look [here](https://github.com/Unity-Technologies/ml-agents/blob/main/docs/Installation.md) for installation docs)

### Installing

* Create and activate the virtual environment

```
$ python -m venv venv
$ source /venv/bin/activate
```
* Install the dependencies
```
$ pip install -r requirements.txt
```

### Executing program

**To run the inference**
* Open the project in Unity to view the Scenes
* Run the program with the already attached model by pressing `Play`

**To train a new model**
* Change the `Behaviour type` to `Default`
* Run the ML-Agent CLI-command with the optional params `config` and `--initialize-from`.
```
mlagents-learn ./config/moveToGoal.yaml --initialize-from=MoveToGoal --run-id=MoveToGoal3
```
* Start the training by pressing `Play`
* End the training by pressing `Stop`
* Attach the displayed `.onnx`-file to the agent
* Change to `Inference only` to see it in action


**To view data about the model**
* Open tensorboard from the root-folder
```
$ tensorboard
```
* Open the tool on the displayed port (defaults to https://localhost:6006)

## Authors

Followed *Code Monkey*'s tutorial which you can find [here](https://www.youtube.com/watch?v=zPFU30tbyKs)