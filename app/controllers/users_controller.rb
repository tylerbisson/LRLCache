class UsersController < ApplicationController
  def index
    render json: User.all
  end

  def show
    @user = User.find(params[:id])
    render json: @user.records 
  end

  def get_current_user 
    render json: current_user
  end
end
