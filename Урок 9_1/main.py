from flask import Flask

app = Flask(__name__)

@app.route('/')
def index():
    return 'Hello, world'
@app.route('/name')
def name():
    return 'You too'

if __name__ == '__main__':
    app.run()
